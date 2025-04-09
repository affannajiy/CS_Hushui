using BlazorHello;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

//Creating the web assembly host: Blazor
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Creating the web assembly host: HttpClient, Lambda Expressions
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();

/*Web Assembly is a single-page application (SPA) which can be rendered on any browser.
 *The web assembly host is used to host the web assembly.*/