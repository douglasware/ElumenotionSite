using System;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace OobaboogaAPIHelper
{
    /// <summary>
    /// ModelParameters represents the parameters used to control a chat model's text generation process.
    /// </summary>
    public class ModelParameters
    {
        public static T FromFile<T>(string filePath) where T : ModelParameters, new()
        {
            T modelParameters = new T();

            foreach (var line in File.ReadLines(filePath))
            {
                var parts = line.Split('=');
                if (parts.Length != 2)
                    continue;

                var propertyName = parts[0].Trim();
                var value = parts[1].Trim();

                var property = typeof(T).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase) ?? throw new Exception($"Unknown property: {propertyName}");
                if (property.PropertyType == typeof(int))
                    property.SetValue(modelParameters, int.Parse(value));
                else if (property.PropertyType == typeof(double))
                    property.SetValue(modelParameters, double.Parse(value));
                else if (property.PropertyType == typeof(bool))
                    property.SetValue(modelParameters, bool.Parse(value));
                else if (property.PropertyType == typeof(string))
                    property.SetValue(modelParameters, value);
                else
                    throw new Exception($"Unsupported property type: {property.PropertyType.Name}");
            }

            return modelParameters;
        }

        public static T FromEmbeddedResource<T>(string resourceName) where T : ModelParameters, new()
        {
            T modelParameters = new T();
            var resource = Utilty.EmbeddedResourceUtility.GetStringFromResource(resourceName);
            var lines = resource.Split('\n');
            foreach (var line in lines)
            {
                var parts = line.Split('=');
                if (parts.Length != 2)
                    continue;

                var propertyName = parts[0].Trim();
                var value = parts[1].Trim();

                var property = typeof(T).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.IgnoreCase) ?? throw new Exception($"Unknown property: {propertyName}");
                if (property.PropertyType == typeof(int))
                    property.SetValue(modelParameters, int.Parse(value));
                else if (property.PropertyType == typeof(double))
                    property.SetValue(modelParameters, double.Parse(value));
                else if (property.PropertyType == typeof(bool))
                    property.SetValue(modelParameters, bool.Parse(value));
                else if (property.PropertyType == typeof(string))
                    property.SetValue(modelParameters, value);
                else
                    throw new Exception($"Unsupported property type: {property.PropertyType.Name}");
            }

            return modelParameters;
        }


        /// <summary>
        /// Maximum number of new tokens to generate, affects the length of generated text.
        /// This is very important as it directly affects the prompt length inversely to the length of the generated text.
        /// Make it small for a bigger prompt. Large for a bigger response.
        /// </summary>
        public int max_new_tokens { get; set; } = 228; //DTW This is very important as it directly affects the prompt length inversely to the length of the generated text. Make it small for a bigger prompt.

        /// <summary>
        /// Controls whether to use contrastive search during generation.
        /// </summary>
        public bool do_sample { get; set; } = true;

        /// <summary>
        /// Controls the randomness of outputs. 0 makes output deterministic, while higher values increase randomness.
        /// </summary>
        public double temperature { get; set; } = 0.7;

        /// <summary>
        /// When not set to 1, only tokens with probabilities adding up to less than this number are selected. Higher values increase the range of possible random results.
        /// </summary>
        public double top_p { get; set; } = 0.5;

        /// <summary>
        /// Selects only the top_k most likely tokens, similar to top_p. Higher values increase the range of possible random results.
        /// </summary>
        public int top_k { get; set; } = 40;

        /// <summary>
        /// Selects only tokens that are at least this much more likely to appear than random tokens, given the prior text.
        /// </summary>
        public double typical_p { get; set; } = 1;

        /// <summary>
        /// Applies an exponential penalty to repeating tokens. 1 means no penalty, higher values reduce repetition, lower values increase repetition.
        /// </summary>
        public double repetition_penalty { get; set; } = 1.2;

        /// <summary>
        /// The "Hallucinations filter", penalizes tokens that are not in the prior text. Higher values make the model stay more in context, lower values allow it to diverge.
        /// </summary>
        public double encoder_repetition_penalty { get; set; } = 1;

        /// <summary>
        /// Specifies the length of token sets that are completely blocked from repeating at all. Higher values block larger phrases, only 0 or high values are recommended.
        /// </summary>
        public double no_repeat_ngram_size { get; set; } = 0;

        /// <summary>
        /// The minimum length of the generated text in tokens.
        /// </summary>
        public int min_length { get; set; } = 0;

        /// <summary>
        /// Penalty alpha parameter, not clearly documented.
        /// </summary>
        public double penalty_alpha { get; set; } = 0;

        /// <summary>
        /// The number of beams in beam search. Higher values can provide better results but use more VRAM.
        /// </summary>
        public int num_beams { get; set; } = 1;

        /// <summary>
        /// The factor by which to multiply the length of the generated text when scoring it. 
        /// </summary>
        public double length_penalty { get; set; } = 1;

        /// <summary>
        /// If true, the generation stops as soon as the model produces a token that satisfies the constraints.
        /// </summary>
        public bool early_stopping { get; set; } = false;

        /// <summary>
        /// The seed for random number generation. Use -1 for random.
        /// </summary>
        public int seed { get; set; } = -1;

        /// <summary>
        /// If true, adds a beginning-of-sentence token to the prompt. Some models need this.
        /// </summary>
        public bool add_bos_token { get; set; } = true;

        /// <summary>
        /// The maximum length of the generated text. If a prompt exceeds this length, the leftmost tokens are removed. Most models require this to be at most 2048.
        /// </summary>
        public int truncation_length { get; set; } = 2048;

        /// <summary>
        /// If true, forbids the model from ending the generation prematurely. Some models need this to be unset.
        /// </summary>
        public bool ban_eos_token { get; set; } = false;

        /// <summary>
        /// If true, the model will skip special tokens in the output. Unsetting this can make replies more creative.
        /// </summary>
        public bool skip_special_tokens { get; set; } = true;

        /// <summary>
        /// This is the maximum string length for a prompt that the API will consume. If your prompt exceeds this length, it will be truncated from the top.
        /// </summary>
        public int max_context_length { get; set; }  = 8192;
    }
}