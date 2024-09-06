[![Pieces](./assets/pieces-logo.png)](https://pieces.app)

# Pieces OS Client SDK For C#

[![GitHub contributors](https://img.shields.io/github/contributors/pieces-app/pieces-os-client-sdk-for-csharp.svg)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/graphs/contributors)
[![GitHub issues by-label](https://img.shields.io/github/issues/pieces-app/pieces-os-client-sdk-for-csharp)](https://github.com/pieces-app/pieces-os-client-sdk-for-csharp/issues)
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