using Blazored.LocalStorage;
using Blazorise;
using Blazorise.Icons.FontAwesome;
using BusinessLogic;
using PostmanBlazorServer.Components;
using PostmanBlazorServer.UIModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddTransient<IMainLogicMethods, MainLogicMethods>(m => new MainLogicMethods());
builder.Services.AddTransient<RequestModel>();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazorise(options =>
{
    options.IconStyle = IconStyle.Light;
    options.IconSize = IconSize.Small;
});
builder.Services.AddFontAwesomeIcons();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
