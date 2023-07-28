using ECommerceAPI.Application.Repositories.EndpointRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.EndpointRepositories
{
    public class EndpointReadRepository : ReadRepository<Endpoint>, IEndpointReadRepository
    {
        public EndpointReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
