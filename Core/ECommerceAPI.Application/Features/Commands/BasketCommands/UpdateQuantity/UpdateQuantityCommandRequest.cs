﻿using MediatR;

namespace ECommerceAPI.Application.Features.Commands.BasketCommands.UpdateQuantity
{
    public class UpdateQuantityCommandRequest : IRequest<UpdateQuantityCommandResponse>
    {
        public string BasketItemId { get; set; }
        public int Quantity { get; set; }
    }
}
