using BusinessLogic;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PostmanBlazorWebAssembly;
using PostmanWebAssembly.UIModel;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<IMainLogicMethods, MainLogicMethods>(m => new MainLogicMethods());
builder.Services.AddTransient<RequestModel>();

await builder.Build().RunAsync();
