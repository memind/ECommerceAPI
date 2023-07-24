using MediatR;

namespace ECommerceAPI.Application.Features.Commands.BasketCommands.AddItemToBasket
{
    public class AddItemToBasketCommandRequest : IRequest<AddItemToBasketCommandResponse>
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
