using BlazorWebAssemblyCRUD.Shared.Data;
using BlazorWebAssemblyCRUD.Shared.Entities;
using BlazorWebAssemblyCRUD.Shared.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWebAssemblyCRUD.Shared.Utils
{
    public static class DIExtensions
    {
        
        public static void AddInfraServices(this IServiceCollection services, IConfigurationManager configuration) 
        {
            services.AddScoped<IGameService, GameService>();      
        }

        public static void AddIdentitfy(this IServiceCollection services)
        {
            services.AddDbContextFactory<AppDataContext>();

        }
    }
}
