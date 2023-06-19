using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OobaboogaAPIHelper
{
    /// <summary>
    /// Represents a single turn in the conversation.
    /// </summary>
    public class Turn
    {
        /// <summary>
        /// Gets or sets the type of the turn ("Human" or "Assistant").
        /// </summary>
        public string TurnType { get; set; }

        /// <summary>
        /// Gets or sets the text of the turn.
        /// </summary>
        public string Content { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the number of tokens in the turn.
        /// </summary>
        public int TokenCount { get; set; }
    }

    /// <summary>
    /// Represents a conversation.
    /// </summary>
    public class Conversation
    {
        public static Conversation FromJsonFile(string jsonFile, PromptTemplate promptTemplate = null)
        {
            var converation = System.Text.Json.JsonSerializer.Deserialize<Conversation>(System.IO.File.ReadAllText(jsonFile));
            converation._promptTemplate = converation._promptTemplate ?? promptTemplate;
            return converation;
        }

        public static void ToJsonFile(Conversation conversation, string jsonFile)
        {
            System.IO.File.WriteAllText(jsonFile, System.Text.Json.JsonSerializer.Serialize(conversation));
        }

        /// <summary>
        /// Gets or sets the initial system prompt.
        /// </summary>
        public string SystemPrompt { get { return _promptTemplate.SystemPrompt; } set { _promptTemplate.SystemPrompt = value; } }

        /// <summary>
        /// Gets or sets the number of tokens in the system prompt.
        /// 13 is the number of tokens in the default system prompt.
        /// </summary>
        public int SystemPromptTokenCount { get; set; } = 13;

        /// <summary>
        /// Gets or sets the list of turns in the conversation.
        /// </summary>
        public List<Turn> Turns { get; set; } = new List<Turn>();

        private PromptTemplate _promptTemplate = new PromptTemplate();

        public Conversation() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation"/> class.
        /// </summary>
        /// <param name="promptTemplate">The PromptTemplate instance containing the configuration.</param>
        public Conversation(PromptTemplate promptTemplate)
        {
            _promptTemplate = promptTemplate;
        }

        /// <summary>
        /// Gets the number of tokens in the conversation.
        /// </summary>
        public int TokenCount
        {
            get
            {
                int tokenCount = SystemPromptTokenCount;
                foreach (var turn in Turns)
                {
                    tokenCount += turn.TokenCount;
                }
                return tokenCount;
            }
        }

        /// <summary>
        /// Parses a conversation from a string of conversation text.
        /// </summary>
        /// <param name="conversationText">The conversation text to parse.</param>
        /// <param name="promptTemplate">The PromptTemplate instance containing the configuration.</param>
        /// <param name="countTokens">A boolean indicating whether or not to count tokens.</param>
        /// <returns>A Task that represents the asynchronous operation. The Task.Result property returns a Conversation object representing the conversation.</returns>
        /// <exception cref="ArgumentNullException">Thrown if conversationText is null.</exception>
        /// <exception cref="FormatException">Thrown if the conversation text is improperly formatted.</exception>
        /// <example>
        /// <code>
        /// string conversationText = "Human: Hello\nAssistant: Hi";
        /// PromptTemplate template = new PromptTemplate();
        /// Conversation conv = await Conversation.ParseConversationAsync(conversationText, template);
        /// </code>
        /// </example>
        public static async Task<Conversation> ParseConversationAsync(string conversationText, PromptTemplate promptTemplate, bool countTokens = false)
        {
            // Validate input
            if (conversationText == null)
            {
                Trace.TraceError("Conversation text cannot be null.");
                throw new ArgumentNullException(nameof(conversationText));
            }

            // Apply configuration values from PromptTemplate
            string humanPrefix = promptTemplate.HumanName;
            string assistantPrefix = promptTemplate.BotName;

            // Remove eos_token if present
            string eosToken = promptTemplate.eos_token;
            if (!string.IsNullOrEmpty(eosToken))
            {
                conversationText = conversationText.Replace(eosToken, "");
            }

            // Validate input
            if (string.IsNullOrEmpty(conversationText))
            {
                Trace.TraceError("Conversation text must include at least one line (the system prompt).");
                throw new FormatException("Conversation text must include at least one line (the system prompt).");
            }

            if (conversationText.Trim().EndsWith(humanPrefix.Substring(0, humanPrefix.Length - 1)))
            {
                conversationText += humanPrefix.Substring(humanPrefix.Length - 1);
            }

            var humanTurns = conversationText.GetInnerTextList(humanPrefix, assistantPrefix);
            var assistantTurns = conversationText.GetInnerTextList(assistantPrefix, humanPrefix);

            var conversation = new Conversation
            {
                SystemPrompt = conversationText?.Split('\n')[0],
                Turns = new List<Turn>()
            };

            for (int i = 0; i < humanTurns.Count; i++)
            {
                var currentTurn = new Turn { TurnType = promptTemplate.HumanNameReplacementToken, Content = humanTurns[i] };
                await AddTurnAsync(conversation, currentTurn, countTokens);
                if (i < assistantTurns.Count)
                {
                    currentTurn = new Turn { TurnType = promptTemplate.BotNameReplacementToken, Content = assistantTurns[i] };
                    await AddTurnAsync(conversation, currentTurn, countTokens);
                }
            }

            return conversation;
        }

        /// <summary>
        /// Builds and returns the chat conversation prompt.
        /// </summary>
        /// <param name="conversation">The Conversation object from which the prompt will be built.</param>
        /// <param name="promptTemplate">The PromptTemplate instance containing the configuration.</param>
        /// <returns>The resulting prompt as a string.</returns>
        public static string GetPrompt(Conversation conversation, PromptTemplate promptTemplate)
        {
            string prompt = conversation.SystemPrompt + "\n\n";
            foreach (var turn in conversation.Turns)
            {
                if (turn.TurnType == promptTemplate.HumanNameReplacementToken)
                {
                    prompt += promptTemplate.HumanName + turn.Content + (!turn.Content.EndsWith("\n") ? "\n" : string.Empty);
                }
                else
                {
                    if (promptTemplate.eos_token != string.Empty)
                    {
                        prompt += promptTemplate.BotName + (turn.Content.EndsWith("\n") ? turn.Content.Substring(0, turn.Content.Length - 1) : turn.Content) + promptTemplate.eos_token + "\n";
                    }
                    else
                    {
                        prompt += promptTemplate.BotName + turn.Content + (!turn.Content.EndsWith("\n") ? "\n" : string.Empty);
                    }
                }
            }
            var nextTurn = conversation.Turns[conversation.Turns.Count - 1].TurnType == promptTemplate.HumanNameReplacementToken ? promptTemplate.BotName : promptTemplate.HumanName;
            if (!prompt.TrimEnd().EndsWith(nextTurn))
            {
                if (!prompt.EndsWith("\n")) prompt += "\n";
                prompt += nextTurn;
            }
            return prompt;
        }

        /// <summary>
        /// Adds a new turn to the conversation with the provided content.
        /// </summary>
        /// <param name="content">The content for the new turn.</param>
        /// <param name="countTokens">A boolean indicating whether or not to count tokens.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        public async Task AddTurn(string content, bool countTokens = true)
        {
            if (Turns.Count == 0)
            {
                await AddTurn(_promptTemplate.HumanNameReplacementToken, content, countTokens);
                return;
            }
            var nextTurnType = Turns[Turns.Count - 1].TurnType == _promptTemplate.HumanNameReplacementToken ? _promptTemplate.BotNameReplacementToken : _promptTemplate.HumanNameReplacementToken;
            await AddTurn(nextTurnType, content, countTokens);
        }

        /// <summary>
        /// Adds a new turn to the conversation with the provided turn type and content.
        /// </summary>
        /// <param name="turnType">The type of the new turn ("Human" or "Assistant").</param>
        /// <param name="content">The content for the new turn.</param>
        /// <param name="countTokens">A boolean indicating whether or not to count tokens.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="ArgumentException">Thrown if turnType is not valid.</exception>
        public async Task AddTurn(string turnType, string content, bool countTokens = true)
        {
            // Validate turnType
            if (turnType != _promptTemplate.HumanNameReplacementToken && turnType != _promptTemplate.BotNameReplacementToken)
            {
                Trace.TraceError($"Invalid turn type: {turnType}. Turn type should be either {_promptTemplate.HumanNameReplacementToken} or {_promptTemplate.BotNameReplacementToken}.");
                throw new ArgumentException($"Invalid turn type: {turnType}. Turn type should be either {_promptTemplate.HumanNameReplacementToken} or {_promptTemplate.BotNameReplacementToken}.");
            }

            var tokenCount = countTokens ? await ApiHelper.GetTokenCountAsync(content) + 3 : 0;
            Turns.Add(new Turn { TurnType = turnType, Content = content, TokenCount = tokenCount });
        }

        /// <summary>
        /// Adds a new turn to the provided conversation.
        /// </summary>
        /// <param name="conversation">The conversation to which the turn will be added.</param>
        /// <param name="currentTurn">The turn to add.</param>
        /// <param name="countTokens">A boolean indicating whether or not to count tokens.</param>
        /// <returns>A Task that represents the asynchronous operation.</returns>
        /// <exception cref="ArgumentNullException">Thrown if conversation or currentTurn is null.</exception>
        private static async Task AddTurnAsync(Conversation conversation, Turn currentTurn, bool countTokens)
        {
            // Validate input
            if (conversation == null)
            {
                Trace.TraceError("Conversation cannot be null.");
                throw new ArgumentNullException(nameof(conversation));
            }

            if (currentTurn == null)
            {
                Trace.TraceError("Turn cannot be null.");
                throw new ArgumentNullException(nameof(currentTurn));
            }

            if (countTokens)
            {
                //3 as padding for the names
                currentTurn.TokenCount = await ApiHelper.GetTokenCountAsync(currentTurn.Content) + 3;
            }
            conversation.Turns.Add(currentTurn);
        }
    }
}


