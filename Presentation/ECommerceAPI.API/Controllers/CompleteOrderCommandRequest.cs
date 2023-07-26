using ECommerceAPI.Application.Features.Commands.OrderCommands.CompleteOrder;
using MediatR;

namespace ECommerceAPI.API.Controllers
{
    public class CompleteOrderCommandRequest : IRequest<CompleteOrderCommandResponse>
    {
        public string Id { get; set; }
    }
}