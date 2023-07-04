using ECommerceAPI.Application.Repositories.ProductRepositories;
using ECommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new(){Id = Guid.NewGuid(), Name = "Product 1", CreateDate = DateTime.UtcNow, Price = 10, Stock = 100},
            //    new(){Id = Guid.NewGuid(), Name = "Product 2", CreateDate = DateTime.UtcNow, Price = 20, Stock = 75},
            //    new(){Id = Guid.NewGuid(), Name = "Product 3", CreateDate = DateTime.UtcNow, Price = 30, Stock = 50}
            //});

            //var count = await _productWriteRepository.SaveAsync();

            //Product p = await _productReadRepository.GetByIdAsync("61627425-adec-46c3-9b18-0c000cc85c94", false);
            //p.Name = "ZAAAAAA";
            //await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
