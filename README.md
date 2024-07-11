# .NET 8 Maui Blazor Hybrid Web Starter Application

This is a clone of the [DotNet 8.0 starter sample](https://github.com/dotnet/blazor-samples/tree/main/8.0/MauiBlazorWeb). The namespaces and references were renamed to be easier to find and replace with a string search.

# How to target mobile and desktop

I use an M1 Mac, so it's ARM64 instead of x64. There's a good chance that BlazorCrossPlatform.Maui.csproj has been altered to use Mac Catalyst and dropped targeting Android and iOS.   

- Find `<PropertyGroup>` and uncomment  
`<!--<TargetFrameworks>net8.0-android;net8.0-ios;net8.0-maccatalyst</TargetFrameworks>-->`  
- Comment out  
  - `<TargetFramework>net8.0-maccatalyst</TargetFramework>`
  - `<RuntimeIdentifiers>maccatalyst-x64;maccatalyst-arm64</RuntimeIdentifiers>`

If you've got a Windows machine, I don't know if you need target something else. Let me know!

# Roadmap

- [X] JSON Localisation.
  - [ ] Fully add all the text. Right now, there are examples for shared and Counter.
- [ ] Add [PrettyBlazor](https://github.com/hassanhabib/PrettyBlazor) and use the building blocks for controls from [Mabrouk Mahdhi's OnDotnetLive repo](https://github.com/mabroukmahdhi/OnDotnetLive). I'll see how far down the rabbit hole I go as far as creating example services and tests etc.
  - [x] Add PrettyBlazor
  - [x] Add base controls
  - [ ] Add brokers
  - [ ] Add services
- [ ] Make a responsive app so that it's ready for web, app and mobile straight out of the box.
- [ ] Maybe I'll add accessibility, but that's really low priority
- [ ] Make the Text Resizer save state
