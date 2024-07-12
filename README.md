# OldPhonePadApp

OldPhonePadApp is a simple Avalonia-based desktop application that converts old phone pad inputs into corresponding text. This project demonstrates how to create a cross-platform GUI application using Avalonia UI and .NET, handling text input and conversion based on the multi-tap input method used in old mobile phones.

## Features

- Converts old phone pad input sequences to text.
- Handles backspace operations.
- Provides a graphical user interface (GUI) for user interaction.
- Cross-platform support (Windows, macOS, and Linux).

## Prerequisites

- [.NET SDK 8.0.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Avalonia UI framework](https://avaloniaui.net/)

## Installation

1. **Clone the repository**:
   ```sh
   git clone https://github.com/rahat-23/OldPhonePadApp.git
   cd OldPhonePadApp
   Install .NET SDK 8.0.0:

2. Download and install the .NET SDK 8.0.0 from the official .NET download page.
3. Build and run the application:dotnet run
Usage
Input Field: Enter the old phone pad string (e.g., 8 88777444666*664#).
Convert Button: Click the "Convert" button to see the corresponding text output in the output field.
Example Inputs and Outputs
Input: 33#
Output: E
Input: 227*#
Output: B
Input: 4433555 555666#
Output: HELLO
Input: 8 88777444666*664#
Output: TURING
Project Structure
OldPhonePadConverter.cs: Contains the logic for converting old phone pad input sequences to text.
MainWindow.xaml: Defines the UI layout.
MainWindow.xaml.cs: Contains the interaction logic for the UI.
