﻿using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.DTOs.Order;
using MediatR;

namespace ECommerceAPI.Application.Features.Commands.OrderCommands.CompleteOrder
{
    public class CompleteOrderCommandHandler : IRequestHandler<CompleteOrderCommandRequest, CompleteOrderCommandResponse>
    {
        readonly IOrderService _orderService;
        readonly IMailService _mailService;

        public CompleteOrderCommandHandler(IOrderService orderService, IMailService mailService)
        {
            _orderService = orderService;
            _mailService = mailService;
        }

        public async Task<CompleteOrderCommandResponse> Handle(CompleteOrderCommandRequest request, CancellationToken cancellationToken)
        {
            (bool succeeded, CompletedOrderDto dto) = await _orderService.CompleteOrderAsync(request.Id);
            if (succeeded)
                await _mailService.SendCompletedOrderMailAsync(dto.EMail, dto.OrderCode, dto.OrderDate, dto.Username);
            return new();
        }
    }
}
