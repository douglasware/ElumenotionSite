using System.Collections.Generic;

namespace DocFxHelper
{
    /// <summary>
    /// Provides structure for various collections in docfx.json
    /// </summary>
    public class BuildContent
    {
        /// <summary>
        /// Files to use
        /// </summary>
#pragma warning disable IDE1006 // Naming Styles
        public List<string> files { get; set; } = new List<string>();

        /// <summary>
        /// Files to exclude
        /// </summary>
        public List<string> exclude { get; set; } = new List<string>() { "obj/**", "_site/**" };
#pragma warning restore IDE1006 // Naming Styles
    }
}