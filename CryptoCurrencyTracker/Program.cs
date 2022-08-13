using CryptoCurrencyTracker;
using CryptoCurrencyTracker.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient());
builder.Services.AddScoped<IApiService, ApiService>();
//builder.Services.AddHttpClient("WebAPI", client =>
//    client.BaseAddress = new Uri("https://api.coingecko.com"));

builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<TooltipService>();
builder.Services.AddScoped<ContextMenuService>();

await builder.Build().RunAsync();
