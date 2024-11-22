using Microsoft.Extensions.AI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pieces.Extensions.AI;
using Pieces.OS.Client;

// Set up the service collection with logging and the chat client
var chatName = $"Recent work reminder {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}";
var services = new ServiceCollection();
services.AddLogging(builder => builder.AddConsole());
services.AddChatClient(new PiecesChatClient(new PiecesClient(), chatName: chatName)).UseLogging();
var serviceProvider = services.BuildServiceProvider();

// Get the chat client
var chatClient = serviceProvider.GetRequiredService<IChatClient>();

// Set up the options for the chat
// We need Pieces Long-Term Memory over the last few hours
var options = new ChatOptions
{
    AdditionalProperties = new AdditionalPropertiesDictionary
    {
        { PiecesChatClient.LongTermMemoryPropertyName, true},
        { PiecesChatClient.LongTermMemoryTimeSpanPropertyName, TimeSpan.FromHours(6) },
    }
};

// Create the chat message
IList<ChatMessage> chatMessages = [];

// Add a system prompt depending on the day

// If we are international talk like a pirate day (Sept 19th), ask for responses in the style of a pirate
if (DateTime.Now.Month == 9 && DateTime.Now.Day == 19)
{
    chatMessages.Add(new(ChatRole.System, "Answer all questions in the style of a pirate."));
}

// If we are Star Wars day (May 4th), ask for responses in the style of a pirate
if (DateTime.Now.Month == 5 && DateTime.Now.Day == 4)
{
    chatMessages.Add(new(ChatRole.System, "Answer all questions in the style of Yoda from star wars."));
}

chatMessages.Add(new(ChatRole.User, "Give me a summary of all the activities I was doing over the last few hours"));

// Send the message and stream the result
await foreach (var r in chatClient.CompleteStreamingAsync(chatMessages, options).ConfigureAwait(false))
{
    // The last message has a copy of the entire text, so only log the non-stop messages
    if (r.FinishReason != ChatFinishReason.Stop)
    {
        Console.Write(r.Text);
    }
}

// Write more instructions for the user
Console.WriteLine("");
Console.WriteLine($"This conversation is persisted in Pieces, called {chatName}. You can ask for more details in this chat in your favorite Pieces extension, or in the desktop app.");
