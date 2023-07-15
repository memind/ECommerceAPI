using ECommerceAPI.Application.Repositories.ProductImageFileRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.ProductImageFileRepositories
{
    public class ProductImageFileWriteRepository : WriteRepository<ProductImageFile>, IProductImageFileWriteRepository
    {
        public ProductImageFileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
