using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;

Console.WriteLine("Hello AI World");
Console.WriteLine("===============");

IChatCompletionService chatService = new AzureOpenAIChatCompletionService("gpt-4o", "https://devday-semantickernel-test.openai.azure.com/", Environment.GetEnvironmentVariable("AI:AzureOpenAI:Key")); 

ChatHistory history = new();

history.AddAssistantMessage("Bonjour, tu es un IA drôle, tu ajoutes une blague développeur à chaque fin de phrase et " +
                       "tu sais que Adrien a 34 ans et il est développeur.");

while (true)
{
    Console.Write("Question ? : ");
    history.AddUserMessage(Console.ReadLine());

    var assistant = await chatService.GetChatMessageContentAsync(history);
    history.Add(assistant);
    Console.WriteLine(assistant);
}