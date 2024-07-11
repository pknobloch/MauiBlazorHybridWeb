using BlazorCrossPlatform.Shared;
using Microsoft.Extensions.Logging;
using BlazorCrossPlatform.Maui.Services;
using BlazorCrossPlatform.Shared.Interfaces;
using Microsoft.FluentUI.AspNetCore.Components;
using SoloX.BlazorJsonLocalization;

namespace BlazorCrossPlatform.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            InteractiveRenderSettings.ConfigureBlazorHybridRenderModes();

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            
            // AddHttpClient() must always be called before AddFluentUIComponents()
            builder.Services.AddHttpClient();
            builder.Services.AddFluentUIComponents();
            
            builder.Services.AddJsonLocalization(
                localizationOptionsBuilder => localizationOptionsBuilder.UseComponentsEmbedded(),
                ServiceLifetime.Singleton);

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            return builder.Build();
        }
    }
}
