using ECommerceAPI.Application.Repositories.InvoiceFileRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.InvoiceFileRepositories
{
    public class InvoiceFileReadRepository : ReadRepository<InvoiceFile>, IInvoiceFileReadRepository
    {
        public InvoiceFileReadRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
