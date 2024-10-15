# Pieces OS Client SDK For C#

The Pieces OS Client SDK is a powerful code engine package designed for writing applications on top of Pieces OS. It facilitates communication with a locally hosted server to enable features such as copilot chats, asset saving, and more.

## Features

The Pieces SDK offers the following key features:

1. Copilot Chats: Communicate seamlessly with copilot chats functionality.
1. Asset Management: Save and manage assets and formats efficiently.
1. Local Server Interaction: Interact with a locally hosted server for various functionality.
1. Multi LLMs support: Use any Pieces supported LLM to power your app.

## Installation

To get started with the Pieces OS Client SDK, follow these steps:

1. **Download Pieces OS**: Pieces OS serves as the primary backend service, providing essential functionality for the SDK. Download the appropriate version for your operating system:
   - [macOS](https://docs.pieces.app/installation-getting-started/macos) 
   - [Windows](https://docs.pieces.app/installation-getting-started/windows) 
   - [Linux](https://docs.pieces.app/installation-getting-started/linux)

1. **Install the SDK**: Use nuget to install the Pieces OS Client SDK package:

   ```shell
   dotnet add package Pieces.OS.Client --prerelease
   ```

## Pieces Client Examples

There is an example project using the Pieces Client in the [`Client.Example`](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/tree/main/src/Client.Example/Program.cs) project. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you wan to run, then run `dotnet run` from the [`Client.Example`](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/tree/main/src/Client.Example) project.

## Quickstart

To set up the SDK, create an instance of the `PiecesClient`. By default this will connect to Pieces OS running locally on the default port, but you can override this by passing in the URL and port as the `baseUrl` parameter.

The `PiecesClient` constructor also optionally takes an `ILogger` to provide full logging for the SDK.

```csharp
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Pieces.OS.Client;

// Set up logging (optional)
var services = new ServiceCollection();
services.AddLogging(builder =>builder.AddConsole());
var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

// Create the Pieces client
IPiecesClient client = new PiecesClient(logger);

// Write out the version
Console.WriteLine($"Pieces OS version: {await client.GetVersionAsync().ConfigureAwait(false)}");
```

### Use the copilot

To interact with the Pieces copilot, use the `IPiecesClient.GetCopilotAsync()` method to return an `IPiecesCopilot` instance.

```csharp
var copilot = await client.GetCopilotAsync().ConfigureAwait(false);
```

Once you have the `IPiecesCopilot`, you can ask questions, and get the response either as a single string, or streaming data.

### Create a chat and ask a question:

This will create a new copilot chat that you will be able to see in other Pieces applications, such as Pieces Desktop, or Pieces for Visual Studio Code. This chat will be named `"C# question on async tasks"`, and you will see this name in other Pieces applications. The chat will ask a question, then return the full answer to the console once it has the complete answer.

```csharp
var chat = await copilot.CreateChatAsync("C# question on async tasks").ConfigureAwait(false);
Console.WriteLine(await chat.AskQuestionAsync("What does the async keyword do in C#?"));
```

### Create a chat and stream the response

This will create a new copilot chat, ask a question, then stream the response back token by token.

```csharp
var chat = await copilot.CreateChatAsync("C# streaming question on primary constructors").ConfigureAwait(false);
await foreach (var token in chat.AskStreamingQuestionAsync("In C#, what is a primary constructor? Give me some example code that declares a class with one."))
{
    Console.Write(token);
}
```

### Interact with assets

To interact with assets in Pieces, such as saved code snippets, use the `IPiecesClient.GetAssetsAsync()` method to return an `IPiecesAssets` instance.

```csharp
var assets = await client.GetAssetsAsync().ConfigureAwait(false);
```

Once you have the `IPiecesAssets`, you can get and create assets.
