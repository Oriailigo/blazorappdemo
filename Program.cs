using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using blazorappdemo;
using Blazored.Toast;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddBlazoredToast();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var apiURL= builder.Configuration.GetValue<string>("apiUrl");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiURL) });
builder.Services.AddScoped<IProductService, ProductService>();


builder.Services.AddScoped<INoticiaService, NoticiaService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();

await builder.Build().RunAsync();
