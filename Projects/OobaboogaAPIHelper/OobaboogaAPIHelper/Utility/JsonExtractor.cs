using System;
using System.Text.Json;

namespace Utilty
{
    public static class JsonExtractor
    {
        /// <summary>
        /// Looks for JSON objects or arrays within a string and returns the first one found.
        /// Handy for dealing with API responses that contain extra text.
        /// </summary>
        /// <param name="input">The text to search</param>
        /// <returns>JSON if found</returns>
        /// <exception cref="ArgumentException">An error if not found</exception>
        public static string ExtractJsonFromString(string input)
        {
            int startIndex = input.IndexOfAny(new[] { '{', '[' });
            int endIndex = input.LastIndexOfAny(new[] { '}', ']' });

            if (startIndex == -1 || endIndex == -1)
            {
                throw new ArgumentException("No JSON object or array found within the string.");
            }

            string jsonString = input.Substring(startIndex, endIndex - startIndex + 1);

            try
            {
                JsonDocument jsonDocument = JsonDocument.Parse(jsonString);
                return jsonString;
            }
            catch (JsonException)
            {
                throw new ArgumentException("Invalid JSON found within the string.");
            }
        }
    }
}
