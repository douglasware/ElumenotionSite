using System.Collections.Generic;

namespace OobaboogaAPIHelper
{
    public class Config
    {
        // static constructor to read settings.json file and set environment variables using System.Text.Json
        public static void Load()
        {
            string settingsJson = System.IO.File.ReadAllText("settings.json");
            _settings = System.Text.Json.JsonSerializer.Deserialize<Dictionary<string, object>>(settingsJson);
        }

        private static Dictionary<string, object> _settings;
        public static int ChatPromptSize { get; set; } = int.Parse(_settings?["chat_prompt_size"].ToString() ?? "2048");
        public static int MaxLength { get; set; } = int.Parse(_settings?["max_length"].ToString() ?? "764");
        public static string SystemPrompt { get; set; } = _settings?["SystemPrompt"].ToString() ?? "A chat between a human and an assistant.";
        public static string ApiHostUrl { get; set; } = _settings?["ApiHostUrl"].ToString() ?? "http://localhost:5000";
    }
}
