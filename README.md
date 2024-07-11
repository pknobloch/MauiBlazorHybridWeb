# .NET 8 Maui Blazor Hybrid Web Starter Application

This is a clone of the [DotNet 8.0 starter sample](https://github.com/dotnet/blazor-samples/tree/main/8.0/MauiBlazorWeb). The namespaces and references were renamed to be easier to find and replace with a string search.

I use an M1 Mac, so it's ARM64 instead of an x64. There's a good chance that BlazorCrossPlatform.Maui.csproj has been altered to use Mac Catalyst and dropped targeting Android and iOS. It's just commented out.

# Roadmap

- [ ] Add [PrettyBlazor](https://github.com/hassanhabib/PrettyBlazor) and use the building blocks for controls from [Mabrouk Mahdhi's OnDotnetLive repo](https://github.com/mabroukmahdhi/OnDotnetLive). I'll see how far down the rabbit hole I go as far as creating example services and tests etc.
- [ ] Make a responsive app so that it's ready for web, app and mobile straight out of the box.
- [ ] Internationalisation.
- [ ] Maybe I'll add accessibility.
