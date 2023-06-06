using System.Collections.Generic;

namespace OobaboogaAPIHelper
{
    /// <summary>
    /// Config helper requires settings.json file in the same directory as the executable.
    /// Will default the values if the file is not found.
    /// </summary>
    public class Config
    {
        // static constructor to read settings.json file and set environment variables using System.Text.Json
        public static void Load()
        {
            try
            {
                string settingsJson = System.IO.File.ReadAllText("settings.json");
                _settings = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(settingsJson);
            }
            catch (System.IO.FileNotFoundException)
            {
                System.Diagnostics.Trace.TraceWarning("settings.json file not found. Using default settings.");
            }
        }

        private static Dictionary<string, object> _settings;
        public static string ApiHostUrl { get; set; } = _settings?["ApiHostUrl"].ToString() ?? "http://localhost:5000";
    }
}
