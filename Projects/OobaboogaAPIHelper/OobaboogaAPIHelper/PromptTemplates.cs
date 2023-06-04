using System.Collections.Generic;

namespace OobaboogaAPIHelper
{
    /// <summary>
    /// Base class for prompt templates with reasonable, but arbitrary defaults.
    /// </summary>
    public class PromptTemplate
    {
        /// <summary>
        /// The token to use for the end of a round. If there is one, this divides the prompt into multiple rounds.
        /// </summary>
        public virtual string eos_token { get; set; } = string.Empty;
        /// <summary>
        /// When the response produced one of the strings, the bot will stop generating text.
        /// These keep the bot from talking to itself.
        /// </summary>
        public virtual List<string> stopping_strings { get; set; } = new List<string> { "\n### Human:", "\n### Assistant:" };
        /// <summary>
        /// Appears at the beginning of the prompt.
        /// </summary>
        public virtual string SystemPrompt { get; set; } = "A chat between a human and an assistant.";
        /// <summary>
        /// The label for the human in the prompt.
        /// </summary>
        public virtual string HumanName { get; set; } = "### Human:";
        /// <summary>
        /// The label for the bot in the prompt.
        /// </summary>
        public virtual string BotName { get; set; } = "### Assistant:";

        public readonly string SystemPromptReplacementToken = "{@SystemPrompt}";
        public readonly string HumanNameReplacementToken = "{@HumanName}";
        public readonly string HumanPromptReplacementToken = "{@HumanPrompt}";
        public readonly string BotNameReplacementToken = "{@BotName}";
    }

    public class Vicuna_v0PromptTemplate : PromptTemplate
    {

    }

    public class Vicuna_v1PromptTemplate : PromptTemplate
    {
        public override string eos_token { get; set; } = "</s>";
        public override string HumanName { get; set; } = "USER:";
        public override string BotName { get; set; } = "ASSISTANT:";
        public override string SystemPrompt { get; set; } = "A chat between a user and an assistant.";
        public override List<string> stopping_strings { get; set; } = new List<string> { "\n### Human:", "\n### Assistant:", "\nUSER:", "\nASSISTANT:", "</s>", "???? " };
    }

    public class Dolly_v2PromptTemplate : PromptTemplate
    {
        public override string HumanName { get; set; } = "### Instruction:";
        public override string BotName { get; set; } = "### Response:";
        public override string SystemPrompt { get; set; } = "Below is an instruction that describes a task. Write a response that appropriately completes the request.";
        public override List<string> stopping_strings { get; set; } = new List<string> { "### End", "\n### " };
    }
}
