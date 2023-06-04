using static OobaboogaAPIHelper.ApiHelper;

namespace OobaboogaAPIHelper
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Config.Load();
            GenerateRequestBody requestBody = Presets.Default;
            requestBody.max_new_tokens = 220;
            
            // Change the following line to use a different prompt template based on the model you are using behind the API.
            var promptTemplate = new Vicuna_v1PromptTemplate();
            var conversation = new Conversation(promptTemplate);
            var lastInput = string.Empty;
            var historyFile = DateTime.Now.Ticks.ToString() + ".json";
            Console.WriteLine(promptTemplate.SystemPrompt);
            do
            {
                Console.WriteLine("==========================================");
                lastInput = Console.ReadLine();
                if (lastInput == "!Exit")
                {
                    break;
                }
                else if (lastInput == "!NewHistory")
                {
                    historyFile = DateTime.Now.Ticks.ToString() + ".json";
                    conversation = new Conversation(promptTemplate);
                }
                if(!string.IsNullOrEmpty(lastInput))
                {
                    await conversation.AddTurn(lastInput);
                    requestBody.prompt = Conversation.GetPrompt(conversation, promptTemplate);
                    Console.WriteLine($"Token Count = {conversation.TokenCount}");
                    Console.WriteLine($"String Length = {requestBody.prompt.Length}");
                    var response = await ApiHelper.GenerateAsync(requestBody, promptTemplate);
                    await conversation.AddTurn(response);
                    
                    // Uncomment this line to save the conversation history to a file as you chat
                    //Conversation.ToJsonFile(conversation, historyFile);
                    Console.WriteLine("==========================================");
                    Console.WriteLine(response);
                }
                
            } while (lastInput != "!Exit");
        }
    }
}