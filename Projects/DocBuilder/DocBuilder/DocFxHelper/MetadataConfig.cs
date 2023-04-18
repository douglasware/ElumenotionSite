namespace DocFxHelper
{
    /// <summary>
    /// 'metadata' portion of Docfx.json
    /// See: https://dotnet.github.io/docfx/tutorial/docfx.exe_user_manual.html#31-properties-for-metadata
    /// </summary>
    public class MetadataConfig
    {
        /// <summary>
        /// Defines the source projects to have metadata generated, which is in File Mapping Format. Relative paths are relative to the docfx.json file being used. To go up a folder use ../.
        /// </summary>
#pragma warning disable IDE1006 // Naming Styles
        public MetadataSrc src { get; set; } = new MetadataSrc();

        /// <summary>
        /// Defines the output folder of the generated metadata files. Relative paths are relative to the docfx.json file being used. To go up a folder use ../.
        /// </summary>
        public string dest { get; set; } = string.Empty;
#pragma warning restore IDE1006 // Naming Styles
    }
}