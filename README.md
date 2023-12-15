# EZLauncher
EZLauncher is a cross-platform .NET library that simplifies the process of opening URLs in the default web browser. It abstracts away the platform specific details, allowing developers to open URLs with a single, easy-to-use function.

## Features:
* Cross-platform support for Windows, macOS, and Linux
* Convenient API for opening URls without worrying about platform specific code.
* Automatically selects the appropriate implementation based on runtime environment.
* Single-flag debugging to help development

# Example Code

## Usage in a Console Application

```csharp
using EZLaunch = EZLauncher.EZLauncher;

class Program
{
    static void Main()
    {
        EZLaunch.Launch("https://www.example.com");
        //EZLaunch.Launch("https://www.example.com", true); // Enables debugging
    }
}
```

# Installation

```bash 
dotnet add package EZLauncher
```