using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using A = DocumentFormat.OpenXml.Drawing;

namespace PowerPointTools.Converters
{
    public class DictionaryToPowerPoint
    {
        /// <summary>
        /// Generates a PowerPoint presentation based on the provided data and saves it to the specified output path.
        /// </summary>
        /// <param name="data">A dictionary where the keys are slide title and values are slide contents</param>
        /// <param name="templatePath">Path to the template PowerPoint presentation</param>
        /// <param name="outputPath">Path to save the PowerPoint presentation</param>
        public void CreatePresentationFromDictionary(Dictionary<string, string> data, string templatePath, string outputPath)
        {
            CreatePowerPointPresentation(templatePath, data, outputPath);
        }

        private static void CreatePowerPointPresentation(string templatePath, Dictionary<string, string> data, string outputPath)
        {
            // Copy the template to the output path
            File.Copy(templatePath, outputPath, true);

            // Open the presentation document
            using PresentationDocument presentationDocument = PresentationDocument.Open(outputPath, true);
            // Copy the first slide as many times as needed
            CopyFirstSlideMultipleTimes(presentationDocument, data.Count);

            // Update the placeholders in the slides
            UpdateSlidePlaceholders(presentationDocument, data);

            // Remove the first slide (template slide)
            RemoveFirstSlide(presentationDocument);
        }

        private static void CopyFirstSlideMultipleTimes(PresentationDocument presentationDocument, int count)
        {
            // Get the presentation part and slide ID list
            PresentationPart presentationPart = presentationDocument.PresentationPart;
            SlideIdList slideIdList = presentationPart.Presentation.SlideIdList;

            // Get the first slide ID and slide part
            SlideId firstSlideId = slideIdList.ChildElements.OfType<SlideId>().FirstOrDefault();
            SlidePart firstSlidePart = (SlidePart)presentationPart.GetPartById(firstSlideId.RelationshipId);
            SlideMasterPart slideMasterPart = presentationPart.SlideMasterParts.FirstOrDefault();

            // Get the slide layout part for the first slide
            SlideLayoutPart firstSlideLayoutPart = firstSlidePart.SlideLayoutPart;

            // Get the layout name of the first slide
            string layoutName = firstSlideLayoutPart.SlideLayout.CommonSlideData.Name.Value;

            // Find the desired slide layout part based on the layout name
            SlideLayoutPart desiredSlideLayoutPart = slideMasterPart.SlideLayoutParts.SingleOrDefault
                (sl => sl.SlideLayout.CommonSlideData.Name.Value.Equals(layoutName, StringComparison.OrdinalIgnoreCase)) ?? throw new Exception("The slide layout " + layoutName + " is not found");

            // Copy the cloned slide part multiple times
            for (int i = 0; i < count; i++)
            {
                // Create a new slide part based on the first slide part
                SlidePart newSlidePart = presentationPart.AddNewPart<SlidePart>();
                using (Stream slideStream = firstSlidePart.GetStream(FileMode.Open))
                {
                    newSlidePart.FeedData(slideStream);
                }

                // Associate the new slide part with the desired slide layout part
                newSlidePart.AddPart(desiredSlideLayoutPart);

                // Get the maximum slide ID or set it to 0
                // if there are no slides
                uint maxSlideId = 0;
                if (slideIdList.ChildElements.Count > 0)
                {
                    maxSlideId = slideIdList.ChildElements
                        .OfType<SlideId>()
                        .Max(slideId => slideId.Id.Value);
                }

                // Create a new slide ID for the new slide
                SlideId newSlideId = new()
                {
                    Id = maxSlideId + 1,
                    RelationshipId = presentationPart.GetIdOfPart(newSlidePart)
                };

                // Append the new slide ID to the slide ID list
                slideIdList.Append(newSlideId);
            }

            // Save the changes to the presentation part
            presentationPart.Presentation.Save();
        }

        private static void UpdateSlidePlaceholders(PresentationDocument presentationDocument, Dictionary<string, string> data)
        {
            // Get the presentation part and slide ID list
            PresentationPart presentationPart = presentationDocument.PresentationPart;
            SlideIdList slideIdList = presentationPart.Presentation.SlideIdList;

            // Iterate through the slides and data, updating placeholders
            int index = 0;
            foreach (KeyValuePair<string, string> entry in data)
            {
                // Get the slide part for the current slide
                SlideId slideId = slideIdList.ChildElements.OfType<SlideId>().ElementAt(index + 1); // Add 1 to skip the first slide (template slide)
                SlidePart slidePart = (SlidePart)presentationPart.GetPartById(slideId.RelationshipId);

                // Get the slide title and content
                string slideTitle = entry.Key;
                string slideContent = entry.Value;

                // Update the title and content placeholders in the slide
                UpdateSlidePlaceholder(slidePart, "{title}", slideTitle);
                UpdateSlidePlaceholder(slidePart, "{content}", slideContent);

                index++;
            }
        }

        private static void UpdateSlidePlaceholder(SlidePart slidePart, string placeholder, string newText)
        {
            // Get the slide and shape tree
            Slide slide = slidePart.Slide;
            ShapeTree shapeTree = slide.CommonSlideData.ShapeTree;

            // Find the shape containing the placeholder text
            Shape targetShape = shapeTree.Descendants<Shape>()
                .FirstOrDefault(shape => shape.Descendants<A.Text>()
                    .Any(text => text.Text.Contains(placeholder)));

            // If the shape is found, update the placeholder text
            if (targetShape != null)
            {
                A.Text targetText = targetShape.Descendants<A.Text>().FirstOrDefault(text => text.Text.Contains(placeholder));
                targetText.Text = targetText.Text.Replace(placeholder, newText);
                slidePart.Slide.Save();
            }
        }

        private static void RemoveFirstSlide(PresentationDocument presentationDocument)
        {
            // Get the presentation part and slide ID list
            PresentationPart presentationPart = presentationDocument.PresentationPart;
            SlideIdList slideIdList = presentationPart.Presentation.SlideIdList;

            // Get the first slide ID
            SlideId firstSlideId = slideIdList.ChildElements.OfType<SlideId>().FirstOrDefault();

            // Remove the first slide ID from the slide ID list
            slideIdList.RemoveChild(firstSlideId);

            // Save the changes to the presentation part
            presentationPart.Presentation.Save();
        }
    }
}