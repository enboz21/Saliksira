using Business;
using Core;
using DataAccsess;
using Entity;
using Entity.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrController : ControllerBase
    {
        private readonly testCore<Randevular, OrDTO> _Or;

        public OrController(testCore<Randevular, OrDTO> or)
        {
            _Or = or;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            try
            {
                var randevular = await _Or.GetAllService();
                if (randevular == null || !randevular.Any())
                {
                    return NotFound("Randevu bulunamadı.");
                }
                return Ok(randevular);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Randevu alınırken hata oluştu: {ex.Message}");
                return StatusCode(500, $"Sunucu hatası oluştu: {ex.Message}");

            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] OrEDTO randevuDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var yeniRandevu = new OrDTO
            {
                HastaId = randevuDto.HastaId,
                DoktorId = randevuDto.DoktorId,
                RandevuDurumuId = randevuDto.RandevuDurumuId
            };

            OrDTO kaydedilenRandevu = await _Or.SaveService(yeniRandevu);

            return StatusCode(201, kaydedilenRandevu);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var randevu = await _Or.GetByIdService(id);
            if (randevu == null)
            {
                return NotFound("Randevu bulunamadı.");
            }
            await _Or.DeleteService(id);
            return NoContent();

        }
    }
}
