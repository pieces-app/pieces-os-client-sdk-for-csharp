# Pieces.Extensions.AI - an implementation of Microsoft.Extensions.AI using Pieces

The Pieces.Extensions.AI package is an implementation of [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI/) using Pieces to provide support for multiple LLMs, as well as adding context such as snippets, files, folders, and live context to your AI conversation.

## Features

The Pieces.Extensions.AI package offers the following key features:

1. `IChatClient` implementation
1. Ability to add files, folders, assets, and local context via the `ChatOptions.AdditionalProperties`
1. Ability to select the model via the `ChatOptions.AdditionalProperties`

## Installation

To get started with the Pieces.Extensions.AI, follow these steps:

1. **Download Pieces OS**: Pieces OS serves as the primary backend service, providing essential functionality for the SDK. Download the appropriate version for your operating system:
   - [macOS](https://docs.pieces.app/installation-getting-started/macos) 
   - [Windows](https://docs.pieces.app/installation-getting-started/windows) 
   - [Linux](https://docs.pieces.app/installation-getting-started/linux)

1. **Install the SDK**: Use nuget to install the Pieces OS Client SDK package:

   ```shell
   dotnet add package Pieces.Extensions.AI --prerelease
   ```

## Pieces.Extensions.AI Examples

There is an example project using the Pieces.Extensions.AI package in the [`Extensions.Example`](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/tree/main/src/Extensions.Example/Program.cs) project. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you want to run, then run `dotnet run` from the [`Extensions.Example`](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/tree/main/src/Extensions.Example) project.

## Quickstart

The `Microsoft.Extensions.AI.IChatClient` interface is implemented in the `PiecesChatClient` object. Create an instance of this using a `IPiecesClient`:

```csharp
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

IChatClient chatClient = new PiecesChatClient(client, chatName: "A new chat", logger: logger);
```

When you use the chat client, a new conversation is created in Pieces, and each time you call `chatClient.CompleteAsync` or `chatClient.CompleteStreamingAsync`, the same conversation is continued - assuming that the original chat messages have not changed. If this happens, a new conversation is created.

You can configure the chat with the following `ChatOptions` settings:

| Setting   | Type     | Default  | Description |
| --------- | -------- | -------- | ----------- |
| `modelId` | `string` | `GPT-4o` | The Id of the model. This can be set using the model Ids from the Pieces.OS.Client SDK. If not set, the current model for the Pieces Client used to create this is used. |

You can also set the following in the `ChatOptions.AdditionalProperties` dictionary:

| Setting               | Type                   | Default  | Description |
| --------------------- | ---------------------- | -------- | ----------- |
| `PersistChat`         | `bool`                 | `true`   | Should the conversation be saved in Pieces? If this is false, after each chat message, the conversation is deleted and a new one started. |
| `AssetIds`            | `IEnumerable<string>?` | `null`   | A list of asset Ids to add as context to this conversation. |
| `Files`               | `IEnumerable<string>?` | `null`   | A list of file paths to add as context to this conversation. |
| `Folders`             | `IEnumerable<string>?` | `null`   | A list of folder paths to add as context to this conversation. |
| `LiveContext`         | `bool`                 | `false`  | Should this conversation include live context. |
| `LiveContextTimeSpan` | `TimeSpan?`            | `null`   | The time span to use for the live context window. |
