using Business;
using DataAccsess;
using Entity;
using Entity.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SitController : ControllerBase
    {
        static AContext c = new AContext();
        SiService _siService = new SiService(new DataBaseAc<Randevular>(c));

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            apreservice _apreservice = new apreservice(c);
            try
            {
                var rapor = await _apreservice.GetAllAp();
                if (rapor == null || !rapor.Any())
                {
                    return NotFound("Basit randevu raporu bulunamadı.");
                }

                return Ok(rapor);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Rapor alınırken hata oluştu: {ex.Message}");
                return StatusCode(500, $"Sunucu hatası oluştu: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RandevuOlusturDto randevuDto)
        {
            if (!ModelState.IsValid) // Otomatik DTO validasyonu için
            {
                return BadRequest(ModelState);
            }

            var yeniRandevu = new Randevular
            {
                HastaId = randevuDto.HastaId,
                DoktorId = randevuDto.DoktorId,
                RandevuDurumu = randevuDto.RandevuDurumu
            };

            Randevular kaydedilenRandevu = await _siService.SaveService(yeniRandevu);

            return StatusCode(201, kaydedilenRandevu);

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var randevu = await _siService.GetByIdService(id);
            if (randevu == null)
            {
                return NotFound("Randevu bulunamadı.");
            }
            await _siService.DeleteService(id);
            return NoContent();

        }
    }
}
