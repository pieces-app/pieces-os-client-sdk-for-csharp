/// This file contains some examples for using the Pieces .NET SDK
///
/// You can find each example in a region below. These examples are commented out, so uncomment each one to run it.
using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pieces.Extensions.AI;
using Pieces.OS.Client;

// Set up logging
var services = new ServiceCollection();
services.AddLogging(builder =>builder.AddConsole());
var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

// Create the Pieces client
IPiecesClient client = new PiecesClient(logger);
var assets = await client.GetAssetsAsync().ConfigureAwait(false);

// Create a Chat completion
IChatClient chatClient = new PiecesChatClient(client);

#region Example 1 - a continuous conversation

// This example shows a continuous conversation. It starts by setting the system prompt,
// then adds a user message, sends this to the chat completion, adds the response to the messages
// then adds another user message and so on. This shows how to build up a conversation.

// // Set the system prompt
// var chatMessages = new List<ChatMessage>{
//     new(ChatRole.System, "Answer every question from now on in the style of a pirate. Start every response with 'Hey matey!'."),
// };

// // Add the first user message
// chatMessages.Add(new ChatMessage(ChatRole.User, "How can I make a web request"));

// // Ask the question
// var response = await chatClient.CompleteAsync(chatMessages).ConfigureAwait(false);
// // Console.WriteLine(response);

// // Add the response to the conversation
// chatMessages.Add(new ChatMessage(ChatRole.User, response.Message!.Text));

// // Ask the next question, but change the model
// chatMessages.Add(new ChatMessage(ChatRole.User, "I want to do this in C#"));

// var options = new ChatOptions()
// {
//     ModelId = "Claude 3.5 Sonnet"
// };
// response = await chatClient.CompleteAsync(chatMessages, options: options).ConfigureAwait(false);
// // Console.WriteLine(response);

// // Add the response to the conversation
// chatMessages.Add(new ChatMessage(ChatRole.User, response.Message!.Text));

// // Ask the next question
// chatMessages.Add(new ChatMessage(ChatRole.User, "Comment this code"));

// // This time stream the response
// await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages).ConfigureAwait(false))
// {
//     Console.Write(r.Text);
// }

// Console.WriteLine();

#endregion Example 1 - a continuous conversation

#region Example 2 - live context

// This example shows how to use live context in a chat completion via the Additional Properties dictionary.
// To run this, read this GitHub issue in your browser before running this: https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/issues/8
// var chatMessages = new List<ChatMessage>{
//     new ChatMessage(ChatRole.User, "Describe the Add support for Microsoft.Extensions.AI github issue I was just reading about in my browser")
// };

// var options = new ChatOptions()
// {
//     AdditionalProperties = new AdditionalPropertiesDictionary{
//         { "LiveContext", true },
//         { "LiveContextTimeSpan", TimeSpan.FromHours(1) }
//     }
// };

// await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages, options: options).ConfigureAwait(false))
// {
//     Console.Write(r.Text);
// }

// Console.WriteLine();

#endregion Example 2 - live context

#region Example 3 - Create an asset and use it in a chat

// This example creates a new asset. It then uses it in a chat asking a question about it.
var assetCode = @"from pieces_os_client.wrapper import PiecesClient

pieces_client = PiecesClient()

# Set the question you want to ask
question = 'What is Object-Oriented Programming?'

# Ask the question and stream the response
for response in pieces_client.copilot.stream_question(question):
   if response.question:
         # Each answer is a chunk of the entire response to the question
         answers = response.question.answers.iterable
         for answer in answers:
            print(answer.text,end='')

# Close the client
pieces_client.close()
";

var newAsset = await assets.CreateAssetAsync(assetCode).ConfigureAwait(false);
Console.WriteLine($"Asset created = name {newAsset.Name}, id: {newAsset.Id}");

var options = new ChatOptions()
{
    AdditionalProperties = new AdditionalPropertiesDictionary{
        { "AssetIds", new List<string>{newAsset.Id} }
    }
};

var chatMessages = new List<ChatMessage>{
    new(ChatRole.User, "Describe this program")
};

await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages, options: options).ConfigureAwait(false))
{
    Console.Write(r.Text);
}

#endregion Example 3 - assets