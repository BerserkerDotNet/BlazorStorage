# BlazorStorage

Simple and reliable version of Local and Session storage for Blazor.
This package is written purely in C# and does not require any JS resource to be loaded in the blazor app.

[![Build Status](https://berserkerdotnet.visualstudio.com/BlazorState.Redux/_apis/build/status/BerserkerDotNet.BlazorState.Redux?branchName=master)](https://berserkerdotnet.visualstudio.com/BlazorState.Redux/_build/latest?definitionId=8&branchName=master)

[![Nuget](https://buildstats.info/nuget/BlazorStorage?v=1.0.0)](https://www.nuget.org/packages/BlazorStorage)

### Usage

1. Install the `BlazorStorage` NuGet package
2. Add required services to the `Startup.cs`
```csharp
services.AddStorage();
```
3. Inject `ILocalStorage` or `ISessionStorage` to your Blazor page.

### Available APIs:
- SetItem - Add key and value to the storage
- GetItem - Retrieve a value by the key from the storage
- RemoveItem - Remove an item by key from the storage
- Clear: Clear all storage items
- Key: Gets the key name by index