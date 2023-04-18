using System.Collections.Generic;

namespace DocFxHelper
{
    /// <summary>
    /// Controls what gets built
    /// See: https://dotnet.github.io/docfx/tutorial/docfx.exe_user_manual.html#32-properties-for-build
    /// </summary>
    public class BuildConfig
    {
        /// <summary>
        /// Contains all the files to generate documentation, including metadata yml files and conceptual md files. name-files file mapping with several ways to define it, as to be described in Section4. The files contains all the project files to have API generated.
        /// </summary>
        public List<BuildContent> content { get; set; } = new List<BuildContent>() { new BuildContent() };
        
        /// <summary>
        /// 	Contains all the resource files that conceptual and metadata files dependent on, e.g. image files. name-files file mapping with several ways to define it, as to be described in Section4.
        /// </summary>
        public List<BuildContent> resource { get; set; } = new List<BuildContent>() { new BuildContent() };
#pragma warning disable IDE1006 // Naming Styles
        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public List<BuildContent> overwrite { get; set; } = new List<BuildContent>() { new BuildContent() };

        /// <summary>
        /// Output destination - set to _site by the POSH module
        /// </summary>
        public string dest { get; set; } = string.Empty;

        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public List<string> globalMetadataFiles { get; set; } = new List<string>();

        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public List<string> fileMetadataFiles { get; set; } = new List<string>();

        /// <summary>
        /// The templates applied to each file in the documentation. It can be a string or an array. The latter ones will override the former ones if the name of the file inside the template collides. If omitted, embedded default template will be used.
        /// </summary>
        public List<string> template { get; set; } = new List<string>();

        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public List<string> postProcessors { get; set; } = new List<string>();

        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public bool noLangKeyword { get; set; }

        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public bool keepFileLink { get; set; }

        /// <summary>
        /// Included for structure and default DocFx behavior
        /// </summary>
        public bool cleanupCacheHistory { get; set; }

#pragma warning restore IDE1006 // Naming Styles
    }
}