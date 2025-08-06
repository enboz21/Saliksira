using Business.@interface;
using Entity.DTOs;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MtController : ControllerBase
    {
        private readonly IMtSer _mtS;
        public MtController(IMtSer mts)
        {
            _mtS = mts;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _mtS.GetAll());
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
            MtDTO A = await _mtS.Save(Mt);
            return CreatedAtAction("Get", A);
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

    }
}
