[![Pieces](https://raw.githubusercontent.com/pieces-app/pieces-os-client-sdk-for-csharp/main/assets/pieces-logo.png?token=GHSAT0AAAAAACTAEQJM63MDD3OICVSXMCLCZW2LDQQ)](https://pieces.app)

# Pieces OS Client SDK For C#

[![GitHub contributors](https://img.shields.io/github/contributors/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/graphs/contributors)
[![GitHub issues by-label](https://img.shields.io/github/issues/pieces-app/pieces-os-client-sdk-for-csharp)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/issues)
[![Pieces OS Client SDK on nuget](https://img.shields.io/nuget/vpre/Pieces.OS.Client)](https://www.nuget.org/packages/Pieces.OS.Client/)
[![Discord](https://img.shields.io/badge/Discord-@layer5.svg?color=7389D8&label&logo=discord&logoColor=ffffff)](https://discord.gg/getpieces)
[![Twitter Follow](https://img.shields.io/twitter/follow/pieces.svg?label=Follow)](https://twitter.com/getpieces)
[![License](https://img.shields.io/github/license/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/blob/main/LICENSE)

## Introduction

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

2. **Install the SDK**: Use nuget to install the Pieces OS Client SDK package:

   ```shell
   dotnet add package Pieces.OS.Client
   ```

## Pieces Client Examples

There is an example project using the Pieces Client in the [`./src/Client.Example`](./src/Client.Example) folder. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you wan to run, then run `dotnet run` from the [`./src/Client.Example`](./src/Client.Example) folder.

### Set up the SDK

To set up the SDK, create an instance of the `PiecesClient`. By default this will connect to Pieces OS running locally on the default port, but you can override this by passing in the URL and port as the `baseUrl` parameter.

The `PiecesClient` constructor also optionally takes an `ILogger` to provide full logging for the SDK.

```csharp
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Pieces.OS.Client;

// Set up logging
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

#### Create a chat and ask a question:

This will create a new copilot chat that you will be able to see in other Pieces applications, such as Pieces Desktop, or Pieces for Visual Studio Code. This chat will be named `"C# question on async tasks"`, and you will see this name in other Pieces applications. The chat will ask a question, then return the full answer to the console once it has the complete answer.

```csharp
var chat = await copilot.CreateChatAsync("C# question on async tasks").ConfigureAwait(false);

Console.WriteLine(await chat.AskQuestionAsync("What does the async keyword do in C#?"));
```

#### Create a chat and ask a question, then a follow up question:

This example creates a copilot chat, and asks 2 connected questions, showing the response from each once it has been completely generated.

```csharp
var chat = await copilot.CreateChatAsync("2 C# questions on async tasks").ConfigureAwait(false);

Console.WriteLine(await chat2.AskQuestionAsync("What does the async keyword do in C#?").ConfigureAwait(false));
Console.WriteLine(await chat2.AskQuestionAsync("Give me an example using it with an HTTP call?").ConfigureAwait(false));
```

#### Create a chat with seeded messages:

This example shows how to seed a conversation with a set of messages that are used in the conversation

```csharp
var seeds = new List<SeedMessage>{
    new(QGPTConversationMessageRoleEnum.SYSTEM, "Answer every question from now on in the style of a pirate. Start every response with 'Hey matey!'."),
    new(QGPTConversationMessageRoleEnum.USER, "How can I make a web request"),
    new(QGPTConversationMessageRoleEnum.ASSISTANT, "To make a web request in a programming language, you typically use an HTTP client library."),
};

var chat = await copilot.CreateSeededChatAsync("C# web requests", 
                                               seeds: seeds).ConfigureAwait(false);

Console.WriteLine(await chat.AskQuestionAsync("What about in C#?").ConfigureAwait(false));
```

#### Stream the response

This will create a new copilot chat, ask a question, then stream the response back token by token.

```csharp
var chat = await copilot.CreateChatAsync("C# streaming question on primary constructors").ConfigureAwait(false);

await foreach (var token in chat.AskStreamingQuestionAsync("In C#, what is a primary constructor? Give me some example code that declares a class with one."))
{
    Console.Write(token);
}
```

#### Use live context

This will create a new copilot chat called 1 hour context window, with live context turned on that you will be able to see in other Pieces applications. You will also be able to see live context turned on against the chat. The chat will ask a question related to this code file using a 1 hour context window, then stream the response back token by token.

```csharp
var chat = await copilot.CreateChatAsync("1 hour context window", useLiveContext: true).ConfigureAwait(false);

await foreach (var token in chat.AskStreamingQuestionAsync("Describe the Program.cs file I was just reading in my IDE", liveContextTimeSpan: TimeSpan.FromHours(1)))
{
    Console.Write(token);
}
```

### Manage models

The SDK allows you to interact with all the available models, including listing them all, and downloading on-device models.

#### List all models

This example lists out all the LLMs Pieces currently supports, including if the model is downloaded for on-device models.

```csharp
foreach (var model in await client.GetModelsAsync().ConfigureAwait(false))
{
    var modelStatus = model.Cloud ? "Cloud model" : "On-device model";
    if (!model.Cloud)
    {
        var downloaded = model.Downloaded ? "downloaded" : "Not downloaded";
        modelStatus += $", {downloaded}";
    }

    Console.WriteLine($"Model: {model.Name}, ID: {model.Id}. {modelStatus}");
}
```

#### Change the model

This example shows how to select a different model and use it for a copilot chat

```csharp
var models = await client.GetModelsAsync().ConfigureAwait(false);
var claudeModel = models.First(m => m.Name.Contains("Claude 3.5 Sonnet", StringComparison.CurrentCultureIgnoreCase));

var chat = await copilot.CreateChatAsync("Chat with a different model", model: claudeModel).ConfigureAwait(false);
```

#### Change the model to a local model

This example shows how to select a local model and use it for a copilot chat. The model is a local model, so may need to be downloaded. If the model needs to be downloaded, you will be able to monitor the progress in Pieces Desktop

```csharp
var models = await client.GetModelsAsync().ConfigureAwait(false);
var llamaModel = models.First(m => m.Name.Contains("Llama-3", StringComparison.CurrentCultureIgnoreCase));

if (!llamaModel.Downloaded)
{
    await client.DownloadModelAsync(llamaModel).ConfigureAwait(false);
}

var chat = await copilot.CreateChatAsync("Chat with a different model", model: llamaModel).ConfigureAwait(false);
```

### Interact with assets

To interact with assets in Pieces, such as saved code snippets, use the `IPiecesClient.GetAssetsAsync()` method to return an `IPiecesAssets` instance.

```csharp
var assets = await client.GetAssetsAsync().ConfigureAwait(false);
```

Once you have the `IPiecesAssets`, you can get and create assets.

#### Load assets

This example loads all the assets in your current Pieces OS and prints the names and programming language.

```csharp
await foreach(var asset in assets.GetAllAssetsAsync())
{
    var language = asset.Formats.Iterable.FirstOrDefault(a => !string.IsNullOrWhiteSpace(a?.Analysis?.Code?.Language))?.Analysis?.Code?.Language;
    Console.WriteLine($"{asset.Name} - {language}");
}
```

#### Create an asset and use it in a copilot chat

This example creates a new asset. It then uses it in a copilot chat asking a question about it.

```csharp
var assetCode = @"using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for their name
        Console.Write(""Please enter your name: "");
        
        // Read the user's input
        string name = Console.ReadLine();
        
        // Print a greeting with the user's name
        Console.WriteLine($""Hello, {name}! Nice to meet you."");
        
        // Wait for the user to press a key before closing the console window
        Console.WriteLine(""Press any key to exit..."");
        Console.ReadKey();
    }
}
";

var newAsset = await assets.CreateAssetAsync(assetCode).ConfigureAwait(false);
Console.WriteLine($"Asset created = name {newAsset.Name}, id: {newAsset.Id}");

var chat = await copilot.CreateChatAsync("C# chat with an asset", assetIds: [newAsset.Id]).ConfigureAwait(false);

await foreach (var token in chat6.AskStreamingQuestionAsync("Describe this C# program"))
{
    Console.Write(token);
}
```
