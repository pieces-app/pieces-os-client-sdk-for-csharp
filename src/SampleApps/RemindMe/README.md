# Remind Me

This is an example app using the [Pieces.Extensions.AI](https://www.nuget.org/packages/Pieces.Extensions.AI/) package to show how to build a small application that leverages live context. This application reminds you of what you were doing over the past few hours.

## How this app works

This application creates the chat client, and sends a message to get the activities over the last few hours using live context. This is controlled by the `ChatOptions`:

```csharp
var options = new ChatOptions
{
    AdditionalProperties = new AdditionalPropertiesDictionary
    {
        { PiecesChatClient.LiveContextPropertyName, true},
        { PiecesChatClient.LiveContextTimeSpanPropertyName, TimeSpan.FromHours(6) },
    }
};
```

This uses a single chat message to get what you were doing over the last few hours:

```csharp
chatMessages.Add(new(ChatRole.User, "Give me a summary of all the activities I was doing over the last few hours"));
```

As a fun easter egg, depending on the day of the year, this will also add a system prompt to guide the output, such as giving the response like a pirate on [international talk like a pirate day](https://talklikeapirate.com), or like Yoda on [Star Wars Day](https://www.starwars.com/star-wars-day).

## Run the code

To run this code, follow these steps:

1. **Download Pieces OS**: Pieces OS serves as the primary backend service, providing essential functionality for the SDK. If you don't have it installed and running already, download the appropriate version for your operating system:
   - [macOS](https://docs.pieces.app/installation-getting-started/macos)
   - [Windows](https://docs.pieces.app/installation-getting-started/windows)
   - [Linux](https://docs.pieces.app/installation-getting-started/linux)
1. Ensure the Workstream Pattern Engine is running.
1. Build and run the app:

    ```shell
    dotnet run
    ```
