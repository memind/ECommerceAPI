using MediatR;

namespace ECommerceAPI.Application.Features.Commands.ProductCommands.RemoveProduct
{
    public class RemoveProductCommandRequest : IRequest<RemoveProductCommandResponse>
    {
        public string Id { get; set; }
    }
}
