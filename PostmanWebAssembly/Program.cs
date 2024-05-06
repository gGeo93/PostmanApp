using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PostmanWebAssembly;
using BusinessLogic;
using PostmanWebAssembly.UIModel;
using Blazored.LocalStorage;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IMainLogicMethods, MainLogicMethods>();
builder.Services.AddTransient<RequestModel>();
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
