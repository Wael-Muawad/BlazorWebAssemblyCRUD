using BlazorWebAssemblyCRUD.Shared.Data;
using BlazorWebAssemblyCRUD.Shared.Services;
using BlazorWebAssemblyCRUD.Shared.Utils;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebAssemblyHostBuilder.CreateDefault(args);



builder.Services.AddScoped(ht => new HttpClient()
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
});


await builder.Build().RunAsync();
