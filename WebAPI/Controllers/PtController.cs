using Business;
using DataAccsess;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PtController : ControllerBase
    {
        static AContext c = new AContext();
        PtEdit PtEdit = new PtEdit(c);
        DataService<Hastalar> Pts = new DataService<Hastalar>(new DataBaseAc<Hastalar>(c));
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await PtEdit.GetAllAp());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await Pts.GetByIdService(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Hastalar hastalar)
        {
            if (hastalar == null)
            {
                return BadRequest("Invalid data.");
            }
            Hastalar A = await Pts.SaveService(hastalar);
            return CreatedAtAction("Get", new { id = A.Id }, A);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var hastalar = await Pts.GetByIdService(id);
            if (hastalar == null)
            {
                return NotFound();
            }
            await Pts.DeleteService(id);
            return NoContent();
        }
        [HttpGet("byname/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await Pts.GetByNameService(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
