using Business;
using Entity;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Identity.Client;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PtDbController : ControllerBase
    {
        public PtDbController()
        {
            // Constructor logic if needed
        }

        [HttpGet]
        public async Task<List<Hastalar>> GetPts()
        {

            List<Hastalar> pts = await new PtBus().GetAllPts();
            return pts;

        }
        

        [HttpGet("{id}")]
        public async Task<IActionResult> getPtsId(int id)
        {
            var H= await new PtBus().GetPtById(id);

            if (H != null)
            {
                return Ok(H);
            }
            return NotFound();
            
        }

        [HttpPost]
        public IActionResult AddPt([FromBody] Hastalar data)
        {
            if (ModelState.IsValid)
            {
                new PtBus().AddPt(data);
                return Ok("başarılı");
            }

            
            return BadRequest("Patient added successfully");
        }
    }
}
