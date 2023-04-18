using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using D = DocumentFormat.OpenXml.Drawing;
using Converters;

namespace PowerPointTools.Converters
{
    /// <summary>
    /// A simple conversion utility for PowerPoint to Markdown
    /// </summary>
    public class PowerPointToMarkdown
    {
        const string CrLf = "\r\n";
        const string MDNewLine = "  \r\n";
        const char Tab = '\t';
        readonly string _pptFilePath;
        readonly string _markdownFolder;
        readonly string _imagesFolder;
        readonly string _imagesFolderPathRelativeToMarkdownFolder;

        /// <summary>
        /// Initializes the converter for the specified PowerPoint document and destination
        /// </summary>
        /// <param name="pptFilePath">The file to convert</param>
        /// <param name="markdownFolder">The absolute path destination for the converted file</param>
        /// <param name="imagesFolder">The absolute path destination for extracted images</param>
        public PowerPointToMarkdown(string pptFilePath, string markdownFolder, string imagesFolder)
        {
            _pptFilePath = pptFilePath;
            _markdownFolder = Path.GetFullPath(markdownFolder);
            if (!_markdownFolder.EndsWith("\\")) _markdownFolder += "\\";
            _imagesFolder = imagesFolder;
            if (!_imagesFolder.EndsWith("\\")) _imagesFolder += "\\";
            _imagesFolderPathRelativeToMarkdownFolder = PathUtility.GetRelativePath(_markdownFolder, _imagesFolder);
            if (!_imagesFolderPathRelativeToMarkdownFolder.EndsWith("\\")) _imagesFolderPathRelativeToMarkdownFolder += "\\";
        }

        /// <summary>
        /// Executes the conversion
        /// </summary>
        /// <param name="markdownFileName">The name of the output file, if empty or null this is the name of the original, but with an MD extension</param>
        public void ConvertToMarkdown(string markdownFileName = null)
        {
            markdownFileName = String.IsNullOrEmpty(markdownFileName) ? $"{Path.GetFileNameWithoutExtension(_pptFilePath)}.md" : markdownFileName;
            var markdownContent = ReadPresentation();

            var outputFilePath = $"{_markdownFolder}{markdownFileName}";
            if (File.Exists(outputFilePath)) File.Delete(outputFilePath);
            File.WriteAllText($"{_markdownFolder}{markdownFileName}", markdownContent);
        }

        private string ReadPresentation()
        {
            var presentationContent = new PresentationContent();
            using var presentationDocument = PresentationDocument.Open(_pptFilePath, false);

            var pptFileNameWithoutExtension = Path.GetFileNameWithoutExtension(_pptFilePath);

            if (presentationDocument == null)
            {
                throw new Exception("Unable to read presentation.");
            }

            // Get a PresentationPart object from the PresentationDocument object.
            PresentationPart presentationPart = presentationDocument.PresentationPart;

            if (presentationPart?.Presentation == null)
            {
                throw new Exception("Presentation has no content");
            }

            // Get a Presentation object from the PresentationPart object.
            Presentation presentation = presentationPart.Presentation;

            if (presentation.SlideIdList != null)
            {
                var firstSection = true;

                // Get the title of each slide in the slide order.
                foreach (var slideId in presentation.SlideIdList.Elements<SlideId>())
                {
                    var slidePart = presentationPart.GetPartById(slideId.RelationshipId) as SlidePart;

                    var slideContent = new SectionContent();
                    var title = GetSlideTitle(slidePart);
                    if (presentationContent.Sections.ContainsKey(title))
                    {
                        slideContent = presentationContent.Sections[title];
                        slideContent.Content += $"{CrLf}";
                    }
                    else
                    {
                        slideContent.Title = title;
                        presentationContent.Sections[title] = slideContent;
                        AddSectionHeading(slideContent);
                    }

                    Dictionary<string, string> slideImages = ExtractImages(slidePart, pptFileNameWithoutExtension);
                    ProcessSlide(slidePart, slideContent, slideImages);

                    if (firstSection)
                    {
                        AddTOC(slideContent);
                        firstSection = false;
                    }
                }
            }
            var output = string.Empty;
            foreach (var key in presentationContent.Sections.Keys)
            {
                output += presentationContent.Sections[key].Content;
            }
            return output;
        }

        private SectionContent ProcessSlide(SlidePart slidePart, SectionContent slideContent, Dictionary<string, string> slideImages)
        {
            var slideData = slidePart.Slide.ChildElements.FirstOrDefault(e => e is CommonSlideData);
            if (slideData == null) return slideContent;

            Console.WriteLine(slideData.GetType());
            ProcessSlideElement(slideData, slideContent);
            ProcessSlideImage(slideData, slideContent, slideImages);

            return slideContent;
        }

        private void ProcessSlideElement(OpenXmlElement element, SectionContent slideContent)
        {
            if (element is D.Table table)
            {
                ProcessTable(table, slideContent);
                slideContent.Content += MDNewLine;
                return;
            }

            if (element is D.Paragraph paragraph)
            {
                AddParagraph(slideContent, paragraph);
            }

            if ((element is Shape && IsBodyShape(element)) || element is not Shape)
            {
                foreach (var child in element.ChildElements)
                {
                    ProcessSlideElement(child, slideContent);
                }
            }
            return;
        }

        private void ProcessTable(D.Table table, SectionContent slideContent)
        {
            var rows = table.Descendants().Where(r => r is D.TableRow).ToList();
            if (rows.Count == 0) return;
            var columnCount = ProcessTableHeader((D.TableRow)rows[0], slideContent);

            for (int i = 1; i < rows.Count; i++)
            {
                ProcessTableRow((D.TableRow)rows[i], slideContent);
            }
        }

        private void ProcessTableRow(D.TableRow tableRow, SectionContent slideContent)
        {
            var cells = tableRow.Descendants().Where((r) => r is D.TableCell);
            if (cells.Count() > 0)
            {
                slideContent.Content += $"{MDNewLine}| ";
                foreach (var cell in cells)
                {
                    slideContent.Content += $" {cell.InnerText} | ";
                }
            }
        }

        private int ProcessTableHeader(D.TableRow tableRow, SectionContent slideContent)
        {
            var cells = tableRow.Descendants().Where((r) => r is D.TableCell);
            if (cells.Count() > 0)
            {
                slideContent.Content += $"{MDNewLine}| ";
                foreach (var cell in cells)
                {
                    slideContent.Content += $" {cell.InnerText} | ";
                }
                slideContent.Content += $"{MDNewLine}| ";
                foreach (var cell in cells)
                {
                    slideContent.Content += $" --- | ";
                }
            }
            return cells.Count();
        }

        private void ProcessSlideImage(OpenXmlElement element, SectionContent slideContent, Dictionary<string, string> slideImages)
        {
            if (element is D.Blip blip && blip.Embed != null && slideImages.ContainsKey(blip.Embed))
            {
                slideContent.Content += $"{MDNewLine}![]({slideImages[blip.Embed]}){MDNewLine}";
            }
            foreach (var child in element.ChildElements)
            {
                ProcessSlideImage(child, slideContent, slideImages);
            }
            return;
        }

        private Dictionary<string, string> ExtractImages(SlidePart slidePart, string pptFileNameWithoutExtension)
        {
            var output = new Dictionary<string, string>();
            if (slidePart.ImageParts.Count() == 0) return new();

            if (!Directory.Exists(_imagesFolder)) Directory.CreateDirectory(_imagesFolder);
            if (!Directory.Exists($"{_imagesFolder}{pptFileNameWithoutExtension}")) Directory.CreateDirectory($"{_imagesFolder}{pptFileNameWithoutExtension}");

            foreach (var imagePart in slidePart.ImageParts)
            {
                try
                {
                    var baseFilePath = $"{_imagesFolder}{pptFileNameWithoutExtension}\\{Path.GetFileName(imagePart.Uri.ToString())}";
                    var outputFileRelativePath = baseFilePath.Replace(_imagesFolder, _imagesFolderPathRelativeToMarkdownFolder);

                    //Save the original 
                    using var stream = imagePart.GetStream();
                    using var outStream = File.OpenWrite(baseFilePath);
                    stream.CopyTo(outStream);
                    outStream.Close();

                    if (imagePart.ContentType != "image/x-wmf" && imagePart.ContentType != "image/x-emf")
                    {
                        output[slidePart.GetIdOfPart(imagePart)] = outputFileRelativePath.Replace("\\", "/").Replace(" ", "%20");
                    }
                    else
                    {
                        //Convert it to png
                        var currentExtension = Path.GetExtension(baseFilePath);
                        using Image convertFrom = new Bitmap(baseFilePath);

                        //use the original extension in the new filename to avoid collisions 
                        var convertedFilePath = baseFilePath.Replace(currentExtension, $"{currentExtension.Remove(0, 1)}.png");

                        convertFrom.Save(convertedFilePath, ImageFormat.Png);
                        output[slidePart.GetIdOfPart(imagePart)] = convertedFilePath.Replace(_imagesFolder, _imagesFolderPathRelativeToMarkdownFolder).Replace("\\", "/").Replace(" ", "%20"); 

                        //Delete the original
                        File.Delete(baseFilePath);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing {imagePart.Uri} - {ex.Message}");
                }
            }
            return output;
        }

        private void AddTOC(SectionContent slideContent)
        {
            //slideContent.Content += $"{CrLf}[[_TOC_]]{CrLf}";
        }

        private void AddSectionHeading(SectionContent slideContent)
        {
            slideContent.Content += $"{MDNewLine}# {slideContent.Title}{CrLf}";
        }

        private void AddParagraph(SectionContent slideContent, D.Paragraph paragraph)
        {
            if (string.IsNullOrWhiteSpace(paragraph.InnerText)) return;

            var paragraphProperties = (D.ParagraphProperties)paragraph.ChildElements.FirstOrDefault(el => el is D.ParagraphProperties);

            if (paragraphProperties?.Level != null && paragraphProperties.Level > 0)
            {
                //Add tab(s) for nested list items
                if (paragraphProperties.Level > 1) slideContent.Content += new string(Tab, paragraphProperties.Level);

                slideContent.Content += $"- {paragraph.InnerText}{CrLf}";
            }
            else
            {
                slideContent.Content += AddNewLineAfterList(paragraph);
                slideContent.Content += $"{paragraph.InnerText}{MDNewLine}";
            }
        }

        private string AddNewLineAfterList(D.Paragraph paragraph)
        {
            if (paragraph.PreviousSibling() is D.Paragraph &&
                ((D.ParagraphProperties)paragraph.PreviousSibling()?.ChildElements.FirstOrDefault(el => el is D.ParagraphProperties))?.Level != null)
            {
                return MDNewLine;
            }
            return string.Empty;
        }

        // Get the title string of the slide.
        private string GetSlideTitle(SlidePart slidePart)
        {
            if (slidePart == null)
            {
                throw new ArgumentNullException("presentationDocument");
            }

            // Declare a paragraph separator.
            string paragraphSeparator = null;

            if (slidePart.Slide != null)
            {
                // Find all the title shapes.
                var shapes = from shape in slidePart.Slide.Descendants()
                             where IsTitleShape(shape)
                             select shape as Shape;

                StringBuilder paragraphText = new();

                foreach (var shape in shapes)
                {
                    // Get the text in each paragraph in this shape.
                    foreach (var paragraph in shape.TextBody.Descendants<D.Paragraph>())
                    {
                        // Add a line break.
                        paragraphText.Append(paragraphSeparator);

                        foreach (var text in paragraph.Descendants<D.Text>())
                        {
                            paragraphText.Append(text.Text);
                        }

                        paragraphSeparator = "\n";
                    }
                }

                return paragraphText.ToString().Trim();
            }

            return string.Empty;
        }

        // Determines whether the shape is a title shape.
        private bool IsTitleShape(OpenXmlElement element)
        {
            if (element is Shape shape)
            {
                var placeholderShape = shape.NonVisualShapeProperties.ApplicationNonVisualDrawingProperties.GetFirstChild<PlaceholderShape>();
                if (placeholderShape != null && placeholderShape.Type != null && placeholderShape.Type.HasValue)
                {
                    switch ((PlaceholderValues)placeholderShape.Type)
                    {
                        // Any title shape.
                        case PlaceholderValues.Title:

                        // A centered title.
                        case PlaceholderValues.CenteredTitle:
                            return true;

                        case PlaceholderValues.SubTitle:
                        case PlaceholderValues.DateAndTime:
                        case PlaceholderValues.Footer:
                        case PlaceholderValues.SlideNumber:
                            //default:
                            return false;
                    }
                }
            }

            return false;
        }

        private bool IsBodyShape(OpenXmlElement element)
        {
            if (element is Shape shape)
            {
                var placeholderShape = shape.NonVisualShapeProperties.ApplicationNonVisualDrawingProperties.GetFirstChild<PlaceholderShape>();
                if (placeholderShape != null && placeholderShape.Type != null && placeholderShape.Type.HasValue)
                {
                    switch ((PlaceholderValues)placeholderShape.Type)
                    {
                        // Any title shape.
                        case PlaceholderValues.Title:
                        case PlaceholderValues.CenteredTitle:
                        case PlaceholderValues.SubTitle:
                        case PlaceholderValues.DateAndTime:
                        case PlaceholderValues.Footer:
                        case PlaceholderValues.SlideNumber:
                            return false;
                    }
                }
            }

            return true;
        }
    }
}
