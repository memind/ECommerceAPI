using MediatR;
namespace ECommerceAPI.Application.Features.Queries.OrderQueries.GetOrderById
{
    public class GetOrderByIdQueryRequest : IRequest<GetOrderByIdQueryResponse>
    {
        public string Id { get; set; }
    }
}
