using ECommerceAPI.Application.Repositories.CustomerRepositories;
using ECommerceAPI.Application.Repositories.OrderRepositories;
using ECommerceAPI.Application.Repositories.ProductRepositories;
using ECommerceAPI.Application.RequestParameters;
using ECommerceAPI.Application.ViewModels.ProductVMs;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ECommerceAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]Pagination pagination)
        {
            var totalCount = _productReadRepository.GetAll(false).Count();
            var products = _productReadRepository.GetAll(false).Skip(pagination.Page * pagination.Size).Take(pagination.Size).Select(p => new
            {
                p.Id,
                p.Name,
                p.Stock,
                p.Price,
                p.CreateDate,
                p.UpdatedDate
            });

            return Ok(new { totalCount, products });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id, false));
        }

        [HttpPost]
        public async Task<IActionResult> Post(ProductCreateVM model)
        {
            if (ModelState.IsValid) { }
            
                await _productWriteRepository.AddAsync(new()
                {
                    Name = model.Name,
                    Price = model.Price,
                    Stock = model.Stock
                });

                await _productWriteRepository.SaveAsync();
                return StatusCode((int)HttpStatusCode.Created);
            

        }

        [HttpPut]
        public async Task<IActionResult> Put(ProductUpdateVM model)
        {
            var product = await _productReadRepository.GetByIdAsync(model.Id);

            product.Stock = model.Stock;
            product.Name = model.Name;
            product.Price = model.Price;

            await _productWriteRepository.SaveAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();

            return Ok();
        }
    }
}
