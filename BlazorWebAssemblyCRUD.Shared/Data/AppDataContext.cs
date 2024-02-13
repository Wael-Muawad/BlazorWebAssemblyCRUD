using BlazorWebAssemblyCRUD.Shared.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyCRUD.Shared.Data
{
    public class AppDataContext : IdentityDbContext<AppUser,AppRole,string>
    {
        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
    }
}
