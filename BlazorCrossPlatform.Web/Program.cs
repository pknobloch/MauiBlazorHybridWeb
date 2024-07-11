using BlazorCrossPlatform.Shared;
using BlazorCrossPlatform.Web.Views;
using BlazorCrossPlatform.Shared.Interfaces;
using BlazorCrossPlatform.Web.Services;
using Microsoft.FluentUI.AspNetCore.Components;
using SoloX.BlazorJsonLocalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// AddHttpClient() must always be called before AddFluentUIComponents()
builder.Services.AddHttpClient();
builder.Services.AddFluentUIComponents();

builder.Services.AddJsonLocalization(
    localizationOptionsBuilder => localizationOptionsBuilder.UseComponentsEmbedded(),
    ServiceLifetime.Singleton);

builder.Services.AddScoped<IFormFactor, FormFactor>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseRequestLocalization();
app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorCrossPlatform.Shared._Imports).Assembly);

await app.RunAsync();
