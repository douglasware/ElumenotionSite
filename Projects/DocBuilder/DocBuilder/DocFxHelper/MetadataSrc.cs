using System.Collections.Generic;

namespace DocFxHelper
{
    /// <summary>
    /// Defines the source projects to have metadata generated, which is in File Mapping Format. Relative paths are relative to the docfx.json file being used. To go up a folder use ../.
    /// </summary>
    public class MetadataSrc
    {
        /// <summary>
        /// Projects or solutions for which to generate the API metadata
        /// </summary>
#pragma warning disable IDE1006 // Naming Styles
        public List<string> files { get; set; } = new List<string>();

        /// <summary>
        /// Folders to exclude
        /// </summary>
        public List<string> exclude { get; set; } = new List<string>() { "obj/**", "**/bin/**", "_site/**" };

        /// <summary>
        /// cwd is Current Working Directory
        /// </summary>
        public string cwd { get; set; } = string.Empty;
#pragma warning restore IDE1006 // Naming Styles
    }
}