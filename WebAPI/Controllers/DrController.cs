
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using System.Threading.Tasks;
using DataAccsess;
using Entity;
using Business;
using Core;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrController : ControllerBase
    {
        static AContext c = new AContext();
        DrEdit DrEdit = new DrEdit(c);
        DataService<Doktorlar> Dts = new DataService<Doktorlar>(new DataBaseAc<Doktorlar>(c));
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await DrEdit.GetAllAp());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await Dts.GetByIdService(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Doktorlar doktor)
        {
            if (doktor == null)
            {
                return BadRequest("Invalid data.");
            }
            Doktorlar dr = await Dts.SaveService(doktor);
            return CreatedAtAction("Get", new {id =dr.Id },dr);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var doktor = await Dts.GetByIdService(id);
            if (doktor == null)
            {
                return NotFound();
            }
            await Dts.DeleteService(id);
            return NoContent();
        }
        [HttpGet("byname/{name}")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await Dts.GetByNameService(name);
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
