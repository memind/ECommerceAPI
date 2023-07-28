using ECommerceAPI.Application.Repositories.EndpointRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.EndpointRepositories
{
    public class EndpointWriteRepository : WriteRepository<Endpoint>, IEndpointWriteRepository
    {
        public EndpointWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
