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
services.AddLogging(builder => builder.AddConsole());
var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

// Create the Pieces client
IPiecesClient client = new PiecesClient(logger);
var assets = await client.GetAssetsAsync().ConfigureAwait(false);

#region A continuous conversation

// This example shows a continuous conversation. It starts by setting the system prompt,
// then adds a user message, sends this to the chat completion, adds the response to the messages
// then adds another user message and so on. This shows how to build up a conversation.

// {
//     // Create a Chat completion
//     IChatClient chatClient = new PiecesChatClient(client, chatName: "Continuous chat", logger: logger);

//     // Set the system prompt
//     var chatMessages = new List<ChatMessage>{
//         new(ChatRole.System, "Answer every question from now on in the style of a pirate."),
//     };

//     // Add the first user message
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Hello"));

//     // Ask the question
//     var response = await chatClient.CompleteAsync(chatMessages).ConfigureAwait(false);
//     Console.WriteLine(response);

//     // Add the response to the conversation
//     chatMessages.Add(new ChatMessage(ChatRole.Assistant, response.Message!.Text));

//     // Ask the next question, but change the model
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Give me a single line of code to create a hello world in C#. No other text."));

//     var options = new ChatOptions()
//     {
//         ModelId = "Claude 3.5 Sonnet"
//     };
//     response = await chatClient.CompleteAsync(chatMessages, options: options).ConfigureAwait(false);
//     Console.WriteLine(response);

//     // Add the response to the conversation
//     chatMessages.Add(new ChatMessage(ChatRole.Assistant, response.Message!.Text));

//     // Ask the next question
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Comment this code"));

//     response = await chatClient.CompleteAsync(chatMessages).ConfigureAwait(false);
//     Console.WriteLine(response);

//     Console.WriteLine();
// }

#endregion A continuous conversation

#region A continuous conversation that doesn't persist the chat

// This example shows a continuous conversation. It starts by setting the system prompt,
// then adds a user message, sends this to the chat completion, adds the response to the messages
// then adds another user message and so on. This shows how to build up a conversation.

// {
//     var options = new ChatOptions()
//     {
//         AdditionalProperties = new AdditionalPropertiesDictionary{
//             { "PersistChat", false }
//         }
//     };

//     // Create a Chat completion
//     IChatClient chatClient = new PiecesChatClient(client, chatName: "Continuous chat that is deleted", logger: logger);

//     // Set the system prompt
//     var chatMessages = new List<ChatMessage>{
//         new(ChatRole.System, "Answer every question from now on in the style of a pirate."),
//     };

//     // Add the first user message
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Hello"));

//     // Ask the question
//     var response = await chatClient.CompleteAsync(chatMessages, options: options).ConfigureAwait(false);
//     Console.WriteLine(response);

//     // Add the response to the conversation
//     chatMessages.Add(new ChatMessage(ChatRole.Assistant, response.Message!.Text));

//     // Ask the next question, but change the model
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Give me a single line of code to create a hello world in C#. No other text."));

//     response = await chatClient.CompleteAsync(chatMessages, options: options).ConfigureAwait(false);
//     Console.WriteLine(response);

//     // Add the response to the conversation
//     chatMessages.Add(new ChatMessage(ChatRole.Assistant, response.Message!.Text));

//     // Ask the next question
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Comment this code"));

//     response = await chatClient.CompleteAsync(chatMessages, options: options).ConfigureAwait(false);
//     Console.WriteLine(response);

//     Console.WriteLine();
// }

#endregion A continuous conversation that doesn't persist the chat

#region A continuous streaming conversation

// This example shows a continuous conversation. It starts by setting the system prompt,
// then adds a user message, sends this to the chat completion, adds the response to the messages
// then adds another user message and so on. This shows how to build up a conversation.

// {
//     // Create a Chat completion
//     IChatClient chatClient = new PiecesChatClient(client, chatName: "Continuous chat", logger: logger);

//     // Set the system prompt
//     var chatMessages = new List<ChatMessage>{
//         new(ChatRole.System, "Answer every question from now on in the style of a pirate."),
//     };

//     // Add the first user message
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Hello"));

//     var response = "";

//     // Ask the question
//     await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages).ConfigureAwait(false))
//     {
//         Console.Write(r.Text);
//         response += r.Text;
//     }

//     // Add the response to the conversation
//     chatMessages.Add(new ChatMessage(ChatRole.Assistant, response));

//     // Ask the next question, but change the model
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Give me a single line of code to create a hello world in C#. No other text."));

//     var options = new ChatOptions()
//     {
//         ModelId = "Claude 3.5 Sonnet"
//     };

//     response = "";

//     // Ask the question
//     await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages, options: options).ConfigureAwait(false))
//     {
//         Console.Write(r.Text);
//         response += r.Text;
//     }

//     // Add the response to the conversation
//     chatMessages.Add(new ChatMessage(ChatRole.Assistant, response));

//     // Ask the next question
//     chatMessages.Add(new ChatMessage(ChatRole.User, "Comment this code"));

//     await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages).ConfigureAwait(false))
//     {
//         Console.Write(r.Text);
//     }

//     Console.WriteLine();
// }

#endregion A continuous streaming conversation

#region Live context

// This example shows how to use live context in a chat completion via the Additional Properties dictionary.
// To run this, read this GitHub issue in your browser before running this: https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/issues/8

// {
//     // Create a Chat completion
//     IChatClient chatClient = new PiecesChatClient(client, logger: logger);

//     var chatMessages = new List<ChatMessage>{
//         new(ChatRole.User, "Describe the Add support for Microsoft.Extensions.AI github issue I was just reading about in my browser")
//     };

//     var options = new ChatOptions()
//     {
//         AdditionalProperties = new AdditionalPropertiesDictionary{
//             { "LiveContext", true },
//             { "LiveContextTimeSpan", TimeSpan.FromHours(1) }
//         }
//     };

//     await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages, options: options).ConfigureAwait(false))
//     {
//         Console.Write(r.Text);
//     }

//     Console.WriteLine();
// }

#endregion Live context

#region Create an asset and use it in a chat

// This example creates a new asset. It then uses it in a chat asking a question about it.

// {
//     // Create a Chat completion
//     IChatClient chatClient = new PiecesChatClient(client, logger: logger);

//     var assetCode = @"from pieces_os_client.wrapper import PiecesClient

//     pieces_client = PiecesClient()

//     # Set the question you want to ask
//     question = 'What is Object-Oriented Programming?'

//     # Ask the question and stream the response
//     for response in pieces_client.copilot.stream_question(question):
//     if response.question:
//             # Each answer is a chunk of the entire response to the question
//             answers = response.question.answers.iterable
//             for answer in answers:
//                 print(answer.text,end='')

//     # Close the client
//     pieces_client.close()
//     ";

//     var newAsset = await assets.CreateAssetAsync(assetCode).ConfigureAwait(false);
//     Console.WriteLine($"Asset created = name {newAsset.Name}, id: {newAsset.Id}");

//     var options = new ChatOptions()
//     {
//         AdditionalProperties = new AdditionalPropertiesDictionary{
//             { "AssetIds", new List<string>{newAsset.Id} }
//         }
//     };

//     var chatMessages = new List<ChatMessage>{
//         new(ChatRole.User, "Describe this program")
//     };

//     await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages, options: options).ConfigureAwait(false))
//     {
//         Console.Write(r.Text);
//     }
// }

#endregion Create an asset and use it in a chat

#region Chat client with a model

// {
//     var llamaModel = await client.DownloadModelAsync("llama-3 8B").ConfigureAwait(false);
//     IChatClient modelChatClient = new PiecesChatClient(client, logger, llamaModel);

//     var chatMessages = new List<ChatMessage>{
//         new(ChatRole.User, "What model are you using"),
//     };

//     var response = await modelChatClient.CompleteAsync(chatMessages).ConfigureAwait(false);
//     Console.WriteLine(response.Message.Text);
// }

#endregion Chat client with a model