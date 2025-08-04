
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
using DataAccsess.Interface;
using Business.@interface;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrController : ControllerBase
    {

        private readonly IDrSer _drDTOService;

        public DrController(IDrSer drDTOService)
        {
            _drDTOService = drDTOService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _drDTOService.GetAll());
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
            DrDTO dr = await _drDTOService.Save(doktor);
            return CreatedAtAction("Get",dr);
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
            var result = await _drDTOService.GetByName(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] DrDTO doktor)
        {
            if (doktor == null)
            {
                return BadRequest("Invalid data.");
            }
            DrDTO dr = await _drDTOService.Update(doktor);
            return CreatedAtAction("Get", dr);
        }

    }
}
