using MediatR;

namespace ECommerceAPI.Application.Features.Queries.ProductImageFileQueries.GetProductImages
{
    public class GetProductImagesQueryRequest : IRequest<List<GetProductImagesQueryResponse>>
    {
        public string Id { get; set; }
    }
}
