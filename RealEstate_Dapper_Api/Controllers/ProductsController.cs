﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public async Task<IActionResult> ProductListWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("DealOfTheDayChangeStatusTrue/{id}")]
        public async Task<IActionResult> DealOfTheDayChangeStatusTrue(int id)
        {
            _productRepository.DealOfTheDayChangeStatusTrue(id);
            return Ok("Günün Favorisi Olarak Eklendi");
        }
        [HttpGet("DealOfTheDayChangeStatusFalse/{id}")]
        public async Task<IActionResult> DealOfTheDayChangeStatusFalse(int id)
        {
            _productRepository.DealOfTheDayChangeStatusFalse(id);
            return Ok("Günün Favorisinden Kaldırırldı");
        }
        [HttpGet("Last5ProductList")] 
        public async Task<IActionResult> Last5ProductList()
        {
            var values = await _productRepository.GetLast5ProductsAsync();
            return Ok(values);
        }
        [HttpGet("ProductAdvertListByEmployeeByTrue")]
        public async Task<IActionResult> ProductAdvertListByEmployeeByTrue(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsyncByTrue(id);
            return Ok(values);
        }
        [HttpGet("ProductAdvertListByEmployeeByFalse")]
        public async Task<IActionResult> ProductAdvertListByEmployeeByFalse(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsyncByFalse(id);
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            await _productRepository.CreateProduct(createProductDto);
            return Ok("İlan Başarıyla Eklendi!");
        }
    }
}
