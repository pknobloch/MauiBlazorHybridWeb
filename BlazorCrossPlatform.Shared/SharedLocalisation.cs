using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;

namespace BlazorCrossPlatform.Shared;

/// <summary>
/// This class is just here to provide an entry point for the shared localization resources.
/// It must be inject with the type `IStringLocalizer<SharedLocalisation>.
/// The private property is simply an example of how you might inject it  
/// </summary>
public class SharedLocalisation
{
    [Inject]
    private IStringLocalizer<SharedLocalisation>? StringLocaliser { get; set; }
}