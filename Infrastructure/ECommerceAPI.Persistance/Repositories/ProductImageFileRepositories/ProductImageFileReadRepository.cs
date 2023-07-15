using ECommerceAPI.Application.Repositories.ProductImageFileRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.ProductImageFileRepositories
{
    public class ProductImageFileReadRepository : ReadRepository<ProductImageFile>, IProductImageFileReadRepository
    {
        public ProductImageFileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
