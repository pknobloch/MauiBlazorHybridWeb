using SoloX.BlazorJsonLocalization;

namespace BlazorCrossPlatform.Shared;

public static class ComponentsEmbeddedExtensions
{
    public static JsonLocalizationOptionsBuilder UseComponentsEmbedded(this JsonLocalizationOptionsBuilder builder)
    {
        return builder.UseEmbeddedJson(options =>
        {
            options.Assemblies = new[] { typeof(ComponentsEmbeddedExtensions).Assembly };
            options.ResourcesPath = "Resources";
        });
    }
}