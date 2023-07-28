using ECommerceAPI.Application.Repositories.MenuRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.MenuRepositories
{
    public class MenuWriteRepository : WriteRepository<Menu>, IMenuWriteRepository
    {
        public MenuWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
