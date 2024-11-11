using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRespositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentLastProductsController : ControllerBase
    {
        private readonly ILast5ProductsRespository _last5ProductsRespository;
        public EstateAgentLastProductsController(ILast5ProductsRespository last5ProductsRespository)
        {
            _last5ProductsRespository = last5ProductsRespository;
        }
        [HttpGet]
        public async Task<IActionResult> GetLast5ProductAsync(int id) 
        {
            var values = await _last5ProductsRespository.GetLast5ProductsAsync(id);
            return Ok(values);
        }
    }
}
