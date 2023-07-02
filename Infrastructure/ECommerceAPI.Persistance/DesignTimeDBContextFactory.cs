using ECommerceAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ECommerceAPI.Persistance
{
    public class DesignTimeDBContextFactory : IDesignTimeDbContextFactory<ECommerceAPIDbContext>
    {
        public ECommerceAPIDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceAPIDbContext> dbContextOptionBuilder = new();
            dbContextOptionBuilder.UseNpgsql(Configurations.ConnectionString);
            return new(dbContextOptionBuilder.Options);
        }
    }
}
