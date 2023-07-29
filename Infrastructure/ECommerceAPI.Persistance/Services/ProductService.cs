﻿using ECommerceAPI.Application.Abstractions.Services;
using ECommerceAPI.Application.Repositories.ProductRepositories;
using ECommerceAPI.Domain.Entities;
using System.Text.Json;

namespace ECommerceAPI.Persistance.Services
{
    public class ProductService : IProductService
    {
        readonly IProductWriteRepository _productWriteRepository;
        readonly IProductReadRepository _productReadRepository;
        readonly IQRCodeService _qrCodeService;
        public ProductService(IProductReadRepository productReadRepository, IQRCodeService qrCodeService, IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _qrCodeService = qrCodeService;
            _productWriteRepository = productWriteRepository;
        }

        public async Task<byte[]> QrCodeToProductAsync(string productId)
        {
            Product product = await _productReadRepository.GetByIdAsync(productId);
            if (product == null)
                throw new Exception("Product not found");

            var plainObject = new
            {
                product.Id,
                product.Name,
                product.Price,
                product.Stock,
                product.CreateDate
            };
            string plainText = JsonSerializer.Serialize(plainObject);

            return _qrCodeService.GenerateQRCode(plainText);
        }

        public async Task StockUpdateToProductAsync(string productId, int stock)
        {
            Product product = await _productReadRepository.GetByIdAsync(productId);
            if (product == null)
                throw new Exception("Product not found");

            product.Stock = stock;
            await _productWriteRepository.SaveAsync();
        }
    }
}