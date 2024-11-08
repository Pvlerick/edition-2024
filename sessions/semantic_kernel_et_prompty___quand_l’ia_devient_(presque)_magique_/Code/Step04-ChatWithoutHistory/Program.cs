using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.AzureOpenAI;

Console.WriteLine("Hello AI World");
Console.WriteLine("===============");

IChatCompletionService chatService = new AzureOpenAIChatCompletionService("gpt-4o", "https://devday-semantickernel-test.openai.azure.com/", Environment.GetEnvironmentVariable("AI:AzureOpenAI:Key")); 

while (true)
{
    Console.Write("Question ? : ");
    Console.WriteLine(await chatService.GetChatMessageContentAsync(Console.ReadLine()));
}