using ECommerceAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Persistance.Context
{
    public class ECommerceAPIDbContext : DbContext
    {
        public ECommerceAPIDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
