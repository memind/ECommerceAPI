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
using ECommerceAPI.Application.Repositories.FileRepositories;
using ECommerceAPI.Application.Repositories.InvoiceFileRepositories;
using ECommerceAPI.Application.Repositories.ProductImageFileRepositories;
using ECommerceAPI.Persistance.Repositories.FileRepositories;
using ECommerceAPI.Persistance.Repositories.ProductImageFileRepositories;
using ECommerceAPI.Persistance.Repositories.InvoiceFileRepositories;
using ECommerceAPI.Domain.Entities.Identity;
using ECommerceAPI.Application.Abstractions.Services.Authentication;
using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Persistence.Services;
using ECommerceAPI.Application.Repositories.BasketItemRepositories;
using ECommerceAPI.Application.Repositories.BasketRepositories;
using ECommerceAPI.Persistance.Repositories.BasketItemRepositories;
using ECommerceAPI.Persistance.Repositories.BasketRepositories;
using ECommerceAPI.Persistance.Services;
using Microsoft.AspNetCore.Identity;
using ECommerceAPI.Persistance.Repositories.CompletedOrderRepositories;
using ECommerceAPI.Application.Repositories.CompletedOrderRepositories;
using ECommerceAPI.Application.Repositories.EndpointRepositories;
using ECommerceAPI.Application.Repositories.MenuRepositories;
using ECommerceAPI.Persistance.Repositories.EndpointRepositories;
using ECommerceAPI.Persistance.Repositories.MenuRepositories;

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
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();
            services.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
            services.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();
            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
            services.AddScoped<ICompletedOrderReadRepository, CompletedOrderReadRepository>();
            services.AddScoped<ICompletedOrderWriteRepository, CompletedOrderWriteRepository>();
            services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();
            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();

            services.AddIdentity<AppUser, AppRole>
                (options =>
                    {
                        options.Password.RequiredLength = 3;
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequireDigit = false;
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                    }
                )
                .AddEntityFrameworkStores<ECommerceAPIDbContext>()
                .AddDefaultTokenProviders();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
        }
    }
}
