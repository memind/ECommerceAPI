using ECommerceAPI.Application.Features.Commands.ProductCommands.CreateProduct;
using ECommerceAPI.Application.Features.Commands.ProductCommands.RemoveProduct;
using ECommerceAPI.Application.Features.Commands.ProductCommands.UpdateProduct;
using ECommerceAPI.Application.Features.Commands.ProductImageFileCommands.RemoveProductImage;
using ECommerceAPI.Application.Features.Commands.ProductImageFileCommands.UploadProductImage;
using ECommerceAPI.Application.Features.Queries.ProductQueries.GetAllProducts;
using ECommerceAPI.Application.Features.Queries.ProductQueries.GetByIdProduct;
using ECommerceAPI.Application.Features.Queries.ProductImageFileQueries.GetProductImages;
using ECommerceAPI.Application.Abstractions.Storage;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Application.ViewModels.ProductVMs;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using MediatR;
using ECommerceAPI.Infrastructure.Services.Storage.Local;
using ECommerceAPI.Persistance.Repositories.FileRepositories;
using ECommerceAPI.Persistance.Repositories.InvoiceFileRepositories;
using ECommerceAPI.Persistance.Repositories.ProductImageFileRepositories;
using ECommerceAPI.Persistance.Repositories.ProductRepositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using ECommerceAPI.Application.Repositories.ProductRepositories;

namespace ECommerceAPI.API.Controllers
{
    // TEST CONTROLLER

    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IWebHostEnvironment _webHostEnvironment;


        private readonly IStorageService _storageService;
        readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            RemoveProductCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Upload([FromQuery] UploadProductImageCommandRequest uploadProductImageCommandRequest)
        {
            uploadProductImageCommandRequest.Files = Request.Form.Files;
            UploadProductImageCommandResponse response = await _mediator.Send(uploadProductImageCommandRequest);
            return Ok();
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetProductImages([FromRoute] GetProductImagesQueryRequest getProductImagesQueryRequest)
        {
            List<GetProductImagesQueryResponse> response = await _mediator.Send(getProductImagesQueryRequest);
            return Ok(response);
        }

        [HttpDelete("[action]/{id}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] RemoveProductImageCommandRequest removeProductImageCommandRequest, [FromQuery] string imageId)
        {
            removeProductImageCommandRequest.ImageId = imageId;
            RemoveProductImageCommandResponse response = await _mediator.Send(removeProductImageCommandRequest);
            return Ok();
        }
    }
}
