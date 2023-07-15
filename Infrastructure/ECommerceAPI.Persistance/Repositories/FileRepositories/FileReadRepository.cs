using ECommerceAPI.Application.Repositories.FileRepositories;
using ECommerceAPI.Persistance.Context;
using F = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistance.Repositories.FileRepositories
{
    public class FileReadRepository : ReadRepository<F::File>, IFileReadRepository
    {
        public FileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
