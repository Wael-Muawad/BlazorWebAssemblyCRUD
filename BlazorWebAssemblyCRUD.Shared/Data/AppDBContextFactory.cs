using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssemblyCRUD.Shared.Data
{
    public class AppDBContextFactory : IDesignTimeDbContextFactory<AppDataContext>
    {
        public AppDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDataContext>();
            optionsBuilder.UseSqlServer(
                "Data Source=WAEL\\SQLEXPRESS;Initial Catalog=VideoGameDB;Trust Server Certificate=True;Integrated Security=True;"
                );
            return new AppDataContext(optionsBuilder.Options);
        }
    }
}
