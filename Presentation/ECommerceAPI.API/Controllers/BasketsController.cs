using ECommerceAPI.Application.Consts;
using ECommerceAPI.Application.CustomAttributes;
using ECommerceAPI.Application.Enums;
using ECommerceAPI.Application.Features.Commands.BasketCommands.AddItemToBasket;
using ECommerceAPI.Application.Features.Commands.BasketCommands.RemoveBasketItem;
using ECommerceAPI.Application.Features.Commands.BasketCommands.UpdateQuantity;
using ECommerceAPI.Application.Features.Queries.BasketQueries.GetBasketItems;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Admin")]
    public class BasketsController : ControllerBase
    {
        readonly IMediator _mediator;

        public BasketsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Baskets, ActionType = ActionType.Reading, Definition = "Get Basket Items")]
        public async Task<IActionResult> GetBasketItems([FromQuery] GetBasketItemsQueryRequest getBasketItemsQueryRequest)
        {
            List<GetBasketItemsQueryResponse> response = await _mediator.Send(getBasketItemsQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Baskets, ActionType = ActionType.Writing, Definition = "Add Item To Basket")]
        public async Task<IActionResult> AddItemToBasket(AddItemToBasketCommandRequest addItemToBasketCommandRequest)
        {
            AddItemToBasketCommandResponse response = await _mediator.Send(addItemToBasketCommandRequest);
            return Ok(response);
        }

        [HttpPut]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Baskets, ActionType = ActionType.Reading, Definition = "Update Quantity")]
        public async Task<IActionResult> UpdateQuantity(UpdateQuantityCommandRequest updateQuantityCommandRequest)
        {
            UpdateQuantityCommandResponse response = await _mediator.Send(updateQuantityCommandRequest);
            return Ok(response);
        }

        [HttpDelete("{BasketItemId}")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Baskets, ActionType = ActionType.Reading, Definition = "Remove Basket Item")]
        public async Task<IActionResult> RemoveBasketItem([FromRoute] RemoveBasketItemCommandRequest removeBasketItemCommandRequest)
        {
            RemoveBasketItemCommandResponse response = await _mediator.Send(removeBasketItemCommandRequest);
            return Ok(response);
        }
    }
}