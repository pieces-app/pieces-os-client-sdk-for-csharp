﻿/// This file contains some examples for using the Pieces .NET SDK
///
/// You can find each example in a region below. These examples are commented out, so uncomment each one to run it.
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client;
using Pieces.OS.Client.Copilot;

// Set up logging
var services = new ServiceCollection();
services.AddLogging(builder =>builder.AddConsole());
var serviceProvider = services.BuildServiceProvider();
var logger = serviceProvider.GetRequiredService<ILogger<Program>>();

// Create the Pieces client
IPiecesClient client = new PiecesClient(logger);

// Get the copilot and asset manager
var copilot = await client.GetCopilotAsync().ConfigureAwait(false);
var assets = await client.GetAssetsAsync().ConfigureAwait(false);

// Write out the version
Console.WriteLine($"Pieces OS version: {await client.GetVersionAsync().ConfigureAwait(false)}");

// Examples

#region Example 0 - list all the models

// Example 0 - list all the models
//
// This example lists out all the LLMs Pieces currently supports

// foreach (var model in await client.GetModelsAsync().ConfigureAwait(false))
// {
//     var modelStatus = model.Cloud ? "Cloud model" : "On-device model";
//     if (!model.Cloud)
//     {
//         var downloaded = model.Downloaded ? "downloaded" : "Not downloaded";
//         modelStatus += $", {downloaded}";
//     }

//     Console.WriteLine($"Model: {model.Name}, ID: {model.Id}. {modelStatus}");
// }

#endregion Example 0 - list all the models

#region Example 1 - create a chat and ask a question:

// Example 1 - create a chat and ask a question
//
// This will create a new copilot chat called C# question on async tasks that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code.
// The chat will ask a question, then return the full answer to the console once it has the answer.

// var chat1 = await copilot.CreateChatAsync("C# question on async tasks").ConfigureAwait(false);

// var question1 = "What does the async keyword do in C#?";
// var response1 = await chat1.AskQuestionAsync(question1);

// Console.WriteLine(question1);
// Console.WriteLine();
// Console.WriteLine(response1);
// Console.WriteLine();

#endregion Example 1 - create a chat and ask a question:

#region Example 2 - create a chat and ask a question, then a follow up question:

// Example 2 - create a chat and ask a question
//
// This will create a new copilot chat called C# question on async tasks that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code.
// The chat will ask a question, then return the full answer to the console once it has the answer.
// It will then ask a follow up question that relies on the first question to make sense, to show how copilot chats can have
// context from previous questions in the same chat.

// var chat2 = await copilot.CreateChatAsync("2 C# questions on async tasks").ConfigureAwait(false);

// var question2 = "What does the async keyword do in C#?";
// var response2 = await chat2.AskQuestionAsync(question2).ConfigureAwait(false);

// var question2FollowUp = "Give me an example using it with an HTTP call?";
// var response2FollowUp = await chat2.AskQuestionAsync(question2FollowUp).ConfigureAwait(false);

// Console.WriteLine(question2);
// Console.WriteLine();
// Console.WriteLine(response2);
// Console.WriteLine();

// Console.WriteLine(question2FollowUp);
// Console.WriteLine();
// Console.WriteLine(response2FollowUp);
// Console.WriteLine();

#endregion Example 2 - create a chat and ask a question, then a follow up question:

#region Example 3 - stream the response

// Example 3 - stream the response
//
// This will create a new copilot chat called C# question on async tasks that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code.
// The chat will ask a question, then stream the response back token by token

// var chat3 = await copilot.CreateChatAsync("C# streaming question on primary constructors").ConfigureAwait(false);

// var question3 = "In C#, what is a primary constructor? Give me some example code that declares a class with one.";
// Console.WriteLine(question3);
// Console.WriteLine();

// await foreach (var token in chat3.AskStreamingQuestionAsync(question3))
// {
//     Console.Write(token);
// }

// Console.WriteLine();

#endregion Example 3 - stream the response

#region Example 4 - use live context

// Example 4 - use live context
//
// This will create a new copilot chat called 1 hour context window, with live context turned on that you will be able to see in other Pieces applications,
// such as Pieces Desktop, or Pieces for Visual Studio Code. You will also be able to see live context turned on against the chat
// The chat will ask a question related to this code file using a 1 hour context window, then stream the response back token by token

// Create a chat with a 1 hour context window
// var chat4 = await copilot.CreateChatAsync("1 hour context window", useLiveContext: true).ConfigureAwait(false);

// var question4 = "Describe the Program.cs file I was just reading in my IDE";
// Console.WriteLine(question4);
// Console.WriteLine();

// await foreach (var token in chat4.AskStreamingQuestionAsync(question4, liveContextTimeSpan: TimeSpan.FromHours(1)))
// {
//     Console.Write(token);
// }

Console.WriteLine();

#endregion Example 4 - use live context

#region Example 5 - Load assets

// Example 5 - load assets
//
// This example loads all the assets in your current Pieces OS and prints the names and language

// await foreach(var asset in assets.GetAllAssetsAsync())
// {
//     var language = asset.Formats.Iterable.FirstOrDefault(a => !string.IsNullOrWhiteSpace(a?.Analysis?.Code?.Language))?.Analysis?.Code?.Language;
//     Console.WriteLine($"{asset.Name} - {language}");
// }

#endregion Example 5 - Load assets

#region Example 6 - Create an asset and use it in a copilot chat

// Example 6 - Create an asset and use it in a copilot chat
//
// This example creates a new asset. It then uses it in a copilot chat asking a question about it.
// var assetCode = @"using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Prompt the user for their name
//         Console.Write(""Please enter your name: "");
        
//         // Read the user's input
//         string name = Console.ReadLine();
        
//         // Print a greeting with the user's name
//         Console.WriteLine($""Hello, {name}! Nice to meet you."");
        
//         // Wait for the user to press a key before closing the console window
//         Console.WriteLine(""Press any key to exit..."");
//         Console.ReadKey();
//     }
// }
// ";

// var newAsset = await assets.CreateAssetAsync(assetCode).ConfigureAwait(false);
// Console.WriteLine($"Asset created = name {newAsset.Name}, id: {newAsset.Id}");

// var chat6 = await copilot.CreateChatAsync("C# chat with an asset", assetIds: [newAsset.Id]).ConfigureAwait(false);

// var question6 = "Describe this C# program";
// Console.WriteLine(question6);
// Console.WriteLine();

// await foreach (var token in chat6.AskStreamingQuestionAsync(question6))
// {
//     Console.Write(token);
// }

// Console.WriteLine();

#endregion Example 6 - Create an asset and use it in a copilot chat

#region Example 7 - Change the model

// Example 7 - Change the model
//
// This example shows how to select a different model and use it for a copilot chat
// If the current model is claude, select GPT-4o, otherwise select Claude

// var models7 = await client.GetModelsAsync().ConfigureAwait(false);
// var claudeModel = models7.First(m => m.Name.Contains("Claude 3.5 Sonnet", StringComparison.CurrentCultureIgnoreCase));
// var gpt4oModel = models7.First(m => m.Name.Contains("GPT-4o", StringComparison.CurrentCultureIgnoreCase));

// var chat7Model = copilot.Model.Id == claudeModel.Id ? gpt4oModel : claudeModel;

// var chat7 = await copilot.CreateChatAsync("Chat with a different model", model: chat7Model).ConfigureAwait(false);
// var question7 = "What LLM are you?";
// Console.WriteLine(question7);
// Console.WriteLine();

// await foreach (var token in chat7.AskStreamingQuestionAsync(question7))
// {
//     Console.Write(token);
// }

#endregion Example 7 - Change the model

#region Example 8 - Change the model to a local model

// Example 8 - Change the model to a local model
//
// This example shows how to select a different model and use it for a copilot chat
// In this case, the model is a local model, so may need to be downloaded. If the model needs to be downloaded,
// you will be able to monitor the progress in Pieces Desktop

// var models8 = await client.GetModelsAsync().ConfigureAwait(false);
// var llamaModel = models8.First(m => m.Name.Contains("Llama-3", StringComparison.CurrentCultureIgnoreCase));
// var phi3Model = models8.First(m => m.Name.Contains("Phi-3", StringComparison.CurrentCultureIgnoreCase));

// var chat8Model = copilot.Model.Id == llamaModel.Id ? phi3Model : llamaModel;

// if (!chat8Model.Downloaded)
// {
//     await client.DownloadModelAsync(chat8Model).ConfigureAwait(false);
// }

// var chat8 = await copilot.CreateChatAsync("Chat with a different model", model: chat8Model).ConfigureAwait(false);
// var question8 = "What LLM are you?";
// Console.WriteLine(question8);
// Console.WriteLine();

// await foreach (var token in chat8.AskStreamingQuestionAsync(question8))
// {
//     Console.Write(token);
// }

#endregion Example 8 - Change the model to a local model

#region Example 9 - Seed a conversation

// Example 9 - Seed a conversation
//
// This example shows how to seed a conversation with a set of messages
// That are used in the conversation

// var seeds = new List<SeedMessage>{
//     new(QGPTConversationMessageRoleEnum.SYSTEM, "Answer every question from now on in the style of a pirate. Start every response with 'Hey matey!'."),
//     new(QGPTConversationMessageRoleEnum.USER, "How can I make a web request"),
//     new(QGPTConversationMessageRoleEnum.ASSISTANT, @"To make a web request in a programming language, you typically use an HTTP client library. Below are examples in a few popular languages:

// ### Python
// You can use the `requests` library to make web requests in Python.

// ```python
// import requests

// response = requests.get('https://api.example.com/data')
// if response.status_code == 200:
//     print(response.json())
// else:
//     print(f'Error: {response.status_code}')
// ```

// ### JavaScript (using Fetch API)
// In JavaScript, you can use the Fetch API to make web requests.

// ```javascript
// fetch('https://api.example.com/data')
//     .then(response => {
//         if (!response.ok) {
//             throw new Error('Network response was not ok ' + response.statusText);
//         }
//         return response.json();
//     })
//     .then(data => console.log(data))
//     .catch(error => console.error('There was a problem with the fetch operation:', error));
// ```

// ### Java (using HttpURLConnection)
// In Java, you can use `HttpURLConnection` to make web requests.

// ```java
// import java.io.BufferedReader;
// import java.io.InputStreamReader;
// import java.net.HttpURLConnection;
// import java.net.URL;

// public class WebRequestExample {
//     public static void main(String[] args) {
//         try {
//             URL url = new URL(""https://api.example.com/data\"");
//             HttpURLConnection conn = (HttpURLConnection) url.openConnection();
//             conn.setRequestMethod(""GET"");

//             int responseCode = conn.getResponseCode();
//             if (responseCode == HttpURLConnection.HTTP_OK) {
//                 BufferedReader in = new BufferedReader(new InputStreamReader(conn.getInputStream()));
//                 String inputLine;
//                 StringBuilder response = new StringBuilder();

//                 while ((inputLine = in.readLine()) != null) {
//                     response.append(inputLine);
//                 }
//                 in.close();
//                 System.out.println(response.toString());
//             } else {
//                 System.out.println(""GET request failed: "" + responseCode);
//             }
//         } catch (Exception e) {
//             e.printStackTrace();
//         }
//     }
// }
// ```

// ### C# (using HttpClient)
// In C#, you can use `HttpClient` to make web requests.

// ```csharp
// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         using (HttpClient client = new HttpClient())
//         {
//             HttpResponseMessage response = await client.GetAsync(""https://api.example.com/data"");
//             if (response.IsSuccessStatusCode)
//             {
//                 string data = await response.Content.ReadAsStringAsync();
//                 Console.WriteLine(data);
//             }
//             else
//             {
//                 Console.WriteLine($""Error: {response.StatusCode}"");
//             }
//         }
//     }
// }
// ```

// Choose the example that fits the programming language you are using!"),
//     new(QGPTConversationMessageRoleEnum.USER, "I am using C#"),
//     new(QGPTConversationMessageRoleEnum.ASSISTANT, @"Great! Since you're using C#, you can use the `HttpClient` class to make web requests. Here's a simple example of how to perform a GET request:

// ```csharp
// using System;
// using System.Net.Http;
// using System.Threading.Tasks;

// class Program
// {
//     static async Task Main()
//     {
//         using (HttpClient client = new HttpClient())
//         {
//             try
//             {
//                 HttpResponseMessage response = await client.GetAsync(""https://api.example.com/data"");
//                 if (response.IsSuccessStatusCode)
//                 {
//                     string data = await response.Content.ReadAsStringAsync();
//                     Console.WriteLine(data);
//                 }
//                 else
//                 {
//                     Console.WriteLine($""Error: {response.StatusCode}"");
//                 }
//             }
//             catch (Exception e)
//             {
//                 Console.WriteLine($""Exception occurred: {e.Message}"");
//             }
//         }
//     }
// }
// ```

// ### Explanation:
// - **HttpClient**: This class is used to send HTTP requests and receive HTTP responses from a resource identified by a URI.
// - **GetAsync**: This method sends a GET request to the specified URI.
// - **IsSuccessStatusCode**: This property checks if the response status code indicates success (2xx).
// - **ReadAsStringAsync**: This method reads the response content as a string asynchronously.

// Make sure to replace `""https://api.example.com/data""` with the actual URL you want to request. If you have any specific requirements or questions, feel free to ask!"),
// };

// var chat9 = await copilot.CreateSeededChatAsync("Question on async tasks", seeds: seeds).ConfigureAwait(false);

// var question9 = "Comment this code";
// var response9 = await chat9.AskQuestionAsync(question9);

// Console.WriteLine(question9);
// Console.WriteLine();
// Console.WriteLine(response9);
// Console.WriteLine();

#endregion Example 9 - Seed a conversation