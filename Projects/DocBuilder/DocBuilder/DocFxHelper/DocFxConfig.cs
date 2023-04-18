using System.Collections.Generic;

namespace DocFxHelper
{
    /// <summary>
    /// The root class in a heirarchy used to create a valid DocFx.json file for statoc site generation.
    /// The DocBuilder PowerShell module populates an instance of the object and its collections
    /// and serializes the result to JSON for consumption by DocFx.
    /// 
    /// See https://dotnet.github.io/docfx/tutorial/docfx.exe_user_manual.html
    /// </summary>
    public class DocFxConfig
    {
        /// <summary>
        /// Configures the source, current working directory, and file types to ignore
        /// </summary>
#pragma warning disable IDE1006 // Naming Styles
        public List<MetadataConfig> metadata { get; set; } = new List<MetadataConfig>() { new MetadataConfig() };

        /// <summary>
        /// Specifies what to build
        /// </summary>
        public BuildConfig build { get; set; } = new BuildConfig();
#pragma warning restore IDE1006 // Naming Styles
    }
}
