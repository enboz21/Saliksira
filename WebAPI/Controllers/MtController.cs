using Business;
using DataAccsess;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core;
using Entity.DTOs;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MtController : ControllerBase
    {
        private readonly testCore<Durum, MtDTO> _mtS;
        public MtController(testCore<Durum, MtDTO> mts)
        {
            _mtS = mts;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mtS.GetAllService());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _mtS.GetByIdService(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MtDTO Mt)
        {
            if (Mt == null)
            {
                return BadRequest("Invalid data.");
            }
            MtDTO A = await _mtS.SaveService(Mt);
            return CreatedAtAction("Get", new { id = A.Id }, A);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Mt = await _mtS.GetByIdService(id);
            if (Mt == null)
            {
                return NotFound();
            }
            await _mtS.DeleteService(id);
            return NoContent();
        }
        /*[HttpGet("byname/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await _mtS.GetByNameService(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }*/
    }
}
