using MediatR;

namespace ECommerceAPI.Application.Features.Commands.ProductImageFileCommands.RemoveProductImage
{
    public class RemoveProductImageCommandRequest : IRequest<RemoveProductImageCommandResponse>
    {
        public string Id { get; set; }
        public string? ImageId { get; set; }
    }
}
