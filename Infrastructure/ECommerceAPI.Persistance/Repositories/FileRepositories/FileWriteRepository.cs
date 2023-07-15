using ECommerceAPI.Application.Repositories.FileRepositories;
using ECommerceAPI.Persistance.Context;
using F = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Persistance.Repositories.FileRepositories
{
    public class FileWriteRepository : WriteRepository<F::File>, IFileWriteRepository
    {
        public FileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
