using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        [HttpGet("ProductAdvertListByEmployee")]
        public async Task<IActionResult> ProductAdvertListByEmployee(int id)
        {
            var values = await _productRepository.GetProductAdvertListByEmployeeAsync(id);
            return Ok(values);
        }
    }
}
