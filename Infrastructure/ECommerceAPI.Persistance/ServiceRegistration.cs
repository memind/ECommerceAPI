using ECommerceAPI.Persistance.Context;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using ECommerceAPI.Application.Repositories.CustomerRepositories;
using ECommerceAPI.Persistance.Repositories.CustomerRepositories;
using ECommerceAPI.Application.Repositories.OrderRepositories;
using ECommerceAPI.Persistance.Repositories.OrderRepositories;
using ECommerceAPI.Application.Repositories.ProductRepositories;
using ECommerceAPI.Persistance.Repositories.ProductRepositories;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistance.Repositories;

namespace ECommerceAPI.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services) 
        {
            services.AddDbContext<ECommerceAPIDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
