
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using DataAccsess;
using Entity;
using Business;
using Core;
using Entity.DTOs;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrController : ControllerBase
    {
        
        private readonly testCore<Doktorlar, DrDTO> _drDTOService;

        public DrController(testCore<Doktorlar, DrDTO> drDTOService)
        {
            _drDTOService = drDTOService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _drDTOService.GetAllService());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _drDTOService.GetByIdService(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] DrDTO doktor)
        {
            if (doktor == null)
            {
                return BadRequest("Invalid data.");
            }
            DrDTO dr = await _drDTOService.SaveService(doktor);
            return CreatedAtAction("Get", new {id =dr.Id },dr);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var doktor = await _drDTOService.GetByIdService(id);
            if (doktor == null)
            {
                return NotFound();
            }
            await _drDTOService.DeleteService(id);
            return NoContent();
        }
        [HttpGet("byname/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await _drDTOService.GetByNameService(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
