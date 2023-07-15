using ECommerceAPI.Application.Repositories.InvoiceFileRepositories;
using ECommerceAPI.Domain.Entities;
using ECommerceAPI.Persistance.Context;

namespace ECommerceAPI.Persistance.Repositories.InvoiceFileRepositories
{
    public class InvoiceFileWriteRepository : WriteRepository<InvoiceFile>, IInvoiceFileWriteRepository
    {
        public InvoiceFileWriteRepository(ECommerceAPIDbContext context) : base(context)
        {
        }
    }
}
