using AngryMonkey.Cloud;
using AngryMonkey.Cloud.Components;
using CVTemplate;
using CVTemplate.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.Services.AddCloudWeb(new CloudWebOptions()
{
    DefaultTitle = "URC",
    TitleSuffix = " - URC",
    SiteBundles = new List<CloudBundle>()
    {
        new CloudBundle(){ Source = "css/site.css"},
        new CloudBundle(){ Source = "CVTemplate.styles.css", MinOnRelease = false},

    }
});

builder.RootComponents.Add<CloudHeadInit>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton(new CloudFiles());
builder.Services.AddScoped(sc => new DataService());

await builder.Build().RunAsync();
