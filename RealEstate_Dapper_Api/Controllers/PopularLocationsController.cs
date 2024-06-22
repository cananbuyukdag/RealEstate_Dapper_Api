using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Repositories.CategoryRepository;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _popularLocationRepository;
        public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
        {
            _popularLocationRepository = popularLocationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreatePopularLocation(CreatePopularLocationDto createpopularLocationDto)
        {
            _popularLocationRepository.CreatePopularLocation(createpopularLocationDto);
            return Ok("Popüler Lokasyon Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePopularLocation(int id)
        {
            _popularLocationRepository.DeletePopularLocation(id);
            return Ok("Popüler Lokasyon Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdatepopularLocation(UpdatePopularLocationDto updatepopularLocationDto)
        {
            _popularLocationRepository.UpdatePopularLocation(updatepopularLocationDto);
            return Ok("Popüler Lokasyon Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetpopularLocation(int id)
        {
            var value = await _popularLocationRepository.GetPopularLocation(id);
            return Ok(value);
        }
    }
}
