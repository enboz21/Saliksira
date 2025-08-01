using Business;
using Business.@interface;
using Core;
using DataAccsess;
using Entity;
using Entity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PtController : ControllerBase
    {
        private readonly IPtSer _pts;
        public PtController(IPtSer pts)
        {
            _pts = pts;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _pts.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _pts.GetByIdService(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PtDTO hastalar)
        {
            if (hastalar == null)
            {
                return BadRequest("Invalid data.");
            }
            PtDTO A = await _pts.Save(hastalar);
            return CreatedAtAction("Get", new { id = A.Id }, A);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var hastalar = await _pts.GetByIdService(id);
            if (hastalar == null)
            {
                return NotFound();
            }
            await _pts.DeleteService(id);
            return NoContent();
        }
        [HttpGet("by-name/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await _pts.GetByName(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpGet("by-tc/{Tc}")]
        public async Task<IActionResult> GetByTc(string Tc)
        {
            var result = await _pts.GetByTc(Tc);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }


    }
}
