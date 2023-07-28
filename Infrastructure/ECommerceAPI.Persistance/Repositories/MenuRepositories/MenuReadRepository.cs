using ECommerceAPI.Application.Repositories.MenuRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.MenuRepositories
{
    public class MenuReadRepository : ReadRepository<Menu>, IMenuReadRepository
    {
        public MenuReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
