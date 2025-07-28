using Business;
using DataAccsess;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MtController : ControllerBase
    {
        static AContext c = new AContext();

        DataService<Randevular> Mts = new DataService<Randevular>(new DataBaseAc<Randevular>(c));
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mts.GetAllService());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await Mts.GetByIdService(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Randevular Mt)
        {
            if (Mt == null)
            {
                return BadRequest("Invalid data.");
            }
            Randevular A = await Mts.SaveService(Mt);
            return CreatedAtAction("Get", new { id = A.Id }, A);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Mt = await Mts.GetByIdService(id);
            if (Mt == null)
            {
                return NotFound();
            }
            await Mts.DeleteService(id);
            return NoContent();
        }
        /*[HttpGet("byname/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await Mts.GetByNameService(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }*/
    }
}
