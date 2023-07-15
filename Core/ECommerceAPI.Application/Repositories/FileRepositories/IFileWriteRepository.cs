using F = ECommerceAPI.Domain.Entities;

namespace ECommerceAPI.Application.Repositories.FileRepositories
{
    public interface IFileWriteRepository : IWriteRepository<F::File>
    {
    }
}
