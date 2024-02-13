using BlazorWebAssemblyCRUD.Components;
using BlazorWebAssemblyCRUD.Shared.Data;
using BlazorWebAssemblyCRUD.Shared.Entities;
using BlazorWebAssemblyCRUD.Shared.Services;
using BlazorWebAssemblyCRUD.Shared.Utils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();


builder.Services.AddInfraServices(builder.Configuration);
builder.Services.AddScoped(ht => new HttpClient()
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseUrl").Value!)
});

builder.Services.AddControllers();
builder.Services.AddIdentity<AppUser,AppRole>()
    .AddEntityFrameworkStores<AppDataContext>();
builder.Services.AddScoped<IGameService, ClientGameService>();

var app = builder.Build();
//!6nHPn_t5yfM6qz
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.MapControllers();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BlazorWebAssemblyCRUD.Client._Imports).Assembly);

app.Run();
