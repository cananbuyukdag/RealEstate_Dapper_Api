using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDtos;
using RealEstate_Dapper_Api.Repositories.CategoryRepository;
using RealEstate_Dapper_Api.Repositories.WhoWeAreRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhoWeAreController : ControllerBase
    {
        private readonly IWhoWeAreRepository _whoWeAreRepository;
        public WhoWeAreController(IWhoWeAreRepository whoWeAreRepository)
        {
            _whoWeAreRepository = whoWeAreRepository;
        }
        [HttpGet]
        public async Task<IActionResult> WhoWeAreList()
        {
            var values = await _whoWeAreRepository.GetAllWhoWeAreAsync();
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateWhoWeAre(CreateWhoWeAreDto createWhoWeAreDto)
        {
            _whoWeAreRepository.CreateWhoWeAre(createWhoWeAreDto);
            return Ok("Hakkımızda Alanı Başarılı Bir Şekilde Eklendi");
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWhoWeAre(int id)
        {
            _whoWeAreRepository.DeleteWhoAre(id);
            return Ok("Hakkımızda Alanı Başarılı Bir Şekilde Silindi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateWhoWeAre(UpdateWhoWeAreDto updateWhoWeAreDto)
        {
            _whoWeAreRepository.UpdateWhoWeAre(updateWhoWeAreDto);
            return Ok("Hakkımızda Alanı Başarıyla Güncellendi");
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDWhoWeAre(int id)
        {
            var value = await _whoWeAreRepository.GetByIDWhoWeAre(id);
            return Ok(value);
        }
    }
}

