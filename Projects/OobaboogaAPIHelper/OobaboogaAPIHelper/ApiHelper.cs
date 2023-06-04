using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections.Generic;

namespace OobaboogaAPIHelper
{
    /// <summary>
    /// A helper class for interacting with the OobaboogaAPI extension.
    /// </summary>
    public class ApiHelper
    {
        /// <summary>
        /// Represents the parameters used to control a chat model's text generation process, including the conversation.
        /// </summary>
        public class GenerateRequestBody : ModelParameters
        {
            /// <summary>
            /// The prompt to use for the generation request.
            /// </summary>
            public string prompt { get; set; }
            /// <summary>
            /// Tells the bot when to stop generating text.
            /// </summary>
            public List<string> stopping_strings { get; set; }
        }

        static readonly HttpClient httpClient = new HttpClient()
        {
            Timeout = TimeSpan.FromMinutes(10)
        };

        /// <summary>
        /// Sends a request to the API to generate a response based on a given request body and prompt template.
        /// </summary>
        /// <param name="requestBody">The request body to use for the generation request.</param>
        /// <param name="promptTemplate">The prompt template to use for the generation request.</param>
        /// <returns>A Task that represents the asynchronous operation. The task result is a string containing the generated text.</returns>
        /// <exception cref="HttpRequestException">Thrown if the API request does not return a success status code.</exception>
        public static async Task<string> GenerateAsync(GenerateRequestBody requestBody, PromptTemplate promptTemplate)
        {
            string URI = $"{Config.ApiHostUrl}/api/v1/generate";
            requestBody.stopping_strings = promptTemplate.stopping_strings;

            // Serialize request body to JSON string
            string requestBodyJson = JsonSerializer.Serialize(requestBody);
            // Create the request content with JSON payload
            var content = new StringContent(requestBodyJson, Encoding.UTF8, "application/json");

            // Send the HTTP POST request
            var response = await httpClient.PostAsync(URI, content);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                using (JsonDocument document = JsonDocument.Parse(responseContent))
                {
                    JsonElement root = document.RootElement;
                    string result = root.GetProperty("results")[0].GetProperty("text").GetString();
                    var resultLines = (result ?? string.Empty).Split('\n');

                    // Remove the last line if it looks like a turn start or an EOS token
                    if (resultLines.Last().StartsWith("###") || resultLines.Last().StartsWith(promptTemplate.eos_token))
                    {
                        Array.Resize(ref resultLines, resultLines.Length - 1);
                        result = string.Join("\n", resultLines);
                    }
                    return result;
                }
            }
            else
            {
                Trace.TraceError($"Error: {response.StatusCode} {response.ReasonPhrase}");
                throw new HttpRequestException($"Error: {response.StatusCode} {response.ReasonPhrase}");
            }
        }

        /// <summary>
        /// Sends a request to the API to get the token count of a given prompt.
        /// </summary>
        /// <param name="prompt">The prompt to get the token count for.</param>
        /// <returns>A Task that represents the asynchronous operation. The task result is an integer representing the token count.</returns>
        /// <exception cref="HttpRequestException">Thrown if the API request does not return a success status code.</exception>
        public static async Task<int> GetTokenCountAsync(string prompt)
        {
            string URI = $"{Config.ApiHostUrl}/api/v1/token-count";
            var content = new StringContent(JsonSerializer.Serialize(new { prompt }), Encoding.UTF8, "application/json");

            var response = await httpClient.PostAsync(URI, content);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                using (JsonDocument document = JsonDocument.Parse(jsonString))
                {
                    JsonElement root = document.RootElement;
                    var data = root.GetProperty("results").ToString();
                    var tokenCountResults = JsonSerializer.Deserialize<TokenCountResult[]>(data);
                    return tokenCountResults[0].tokens;
                }
            }
            else
            {
                Trace.TraceError($"Error in response: {response.StatusCode}");
                throw new HttpRequestException($"Error in response: {response.StatusCode}");
            }
        }

        /// <summary>
        /// Represents the response from a token count request.
        /// </summary>
        public class TokenCountResult
        {
            /// <summary>
            /// Gets or sets the token count in the response.
            /// </summary>
            public int tokens { get; set; }
        }
    }
}

