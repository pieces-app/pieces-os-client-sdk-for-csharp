[![Pieces](https://raw.githubusercontent.com/pieces-app/pieces-os-client-sdk-for-csharp/main/assets/pieces-logo.png?token=GHSAT0AAAAAACTAEQJM63MDD3OICVSXMCLCZW2LDQQ)](https://pieces.app)

# Pieces OS Client SDK For C#

[![GitHub contributors](https://img.shields.io/github/contributors/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/graphs/contributors)
[![GitHub issues by-label](https://img.shields.io/github/issues/pieces-app/pieces-os-client-sdk-for-csharp)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/issues)
![Publish Client Workflow Status](https://img.shields.io/github/actions/workflow/status/pieces-app/pieces-os-client-sdk-for-csharp/publish-client-nuget.yaml)
![Publish Extensions Workflow Status](https://img.shields.io/github/actions/workflow/status/pieces-app/pieces-os-client-sdk-for-csharp/publish-extensions-nuget.yaml)
[![License](https://img.shields.io/github/license/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/blob/main/LICENSE)

[![NuGet Version](https://img.shields.io/nuget/v/Pieces.OS.Client?label=Pieces.OS.Client%20on%20nuget)](https://www.nuget.org/packages/Pieces.OS.Client/)
[![Pieces.Extensions.AI SDK on nuget](https://img.shields.io/nuget/vpre/Pieces.Extensions.AI?label=Pieces.Extensions.AI%20on%20nuget)](https://www.nuget.org/packages/Pieces.Extensions.AI/)

[![Discord](https://img.shields.io/badge/Discord-@layer5.svg?color=7389D8&label&logo=discord&logoColor=ffffff)](https://discord.gg/getpieces)
[![Twitter Follow](https://img.shields.io/twitter/follow/pieces.svg?label=Follow)](https://twitter.com/getpieces)

## Introduction

The Pieces OS Client SDK is a set of powerful code engine packages designed for writing applications on top of Pieces OS. It facilitates communication with a locally hosted server to enable features such as copilot chats, asset saving, and more.

This SDK has 2 packages:

- [Pieces.OS.Client](https://www.nuget.org/packages/Pieces.OS.Client/) - this is the core SDK package providing access to the features of Pieces from your C# application
- [Pieces.Extensions.AI](https://www.nuget.org/packages/Pieces.Extensions.AI/) - this is an implementation of [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI/) using Pieces to provide support for multiple LLMs, as well as adding context such as snippets, files, folders, and Pieces Long-Term Memory to your AI conversation.

## Features

The Pieces SDK offers the following key features:

1. Copilot Chats: Communicate seamlessly with copilot chats functionality.
1. Asset Management: Save and manage assets and formats efficiently.
1. Local Server Interaction: Interact with a locally hosted server for various functionality.
1. Multi-LLM support: Use any Pieces supported LLM to power your app.
1. File, folder, and Pieces Long-Term Memory in copilot chats

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

1. **Install the Extensions SDK**: If you want [Microsoft.Extensions.AI](https://www.nuget.org/packages/Microsoft.Extensions.AI/) support, install the Pieces.Extensions.AI package:

    ```shell
    dotnet add package Pieces.Extensions.AI --prerelease
    ```

## Projects

This repo contains the following projects:

- [Pieces.OS.Client](./src/Client/) - the OS client SDK
- [Pieces.Extensions.AI](./src/Extensions/) - support for Microsoft.Extensions.AI
- [Pieces.OS.Core](./src/Core/) - an internal library wrapping the Pieces OS API
- [Pieces.OS.Client.Example](./src/Client.Example/) - example code for using the Pieces.OS.Client SDK
- [Pieces.Extensions.AI.Example](./src/Extensions.Example/) - example code for using the Pieces.Extensions.AI SDK
- [SampleApps](./src/SampleApps/) - a selection of sample apps

### Sample apps

- [Remind Me](./src/SampleApps/RemindMe/) - an app that reminds you about what you have been working on over the last few hours using Pieces Long-Term Memory.

## Pieces.OS.Client Examples

There is an example project using the Pieces.OS.Client package in the [`./src/Client.Example`](./src/Client.Example) folder. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you want to run, then run `dotnet run` from the [`./src/Client.Example`](./src/Client.Example) folder.

Details of this example project are provided in the [src/Client/README.md file](./src/Client/README.md).

## Pieces.Extensions.AI Examples

There is an example project using the Pieces.Extensions.AI package in the [`./src/Extensions.Example`](./src/Extensions.Example) folder. This example is a console app containing a range of different examples, each commented out. To run these examples, uncomment the one you want to run, then run `dotnet run` from the [`./src/Extensions.Example`](./src/Extensions.Example) folder.

Details of this example project are provided in the [src/Extensions/README.md file](./src/Extensions/README.md).

## Publish the packages

This repo includes GitHub actions to publish both the Pieces.OS.Client and Pieces.Extensions.AI packages.

The Pieces.Extensions.AI package is dependent on the Pieces.OS.Client package. The way this is implemented is:

- In this repo, the Pieces.Extensions.AI project has a project dependency on Pieces.OS.Client and Pieces.OS.Core
- In the action to publish, this project dependency is removed, and a nuget package dependency is added to the latest pre-release Pieces.OS.Core.

To publish these packages, do the following:

- Tag this repo using a tag of `client-v<x.y.z-a>` where `<x.y.z-a>` is the version string. For example, to release `0.0.10-beta` you would tag with `client-v0.0.10-beta`. This will only build and publish the Pieces.OS.Client package.
- Once the Pieces.OS.Client package has been validated and made public on nuget, tag the repo using a tag of `extensions-v<x.y.z-a>`, for example `extensions-v0.0.10-beta`. This will build the Pieces.Extensions.AI package using the nuget package reference to Pieces.OS.Client, and publish to nuget.
