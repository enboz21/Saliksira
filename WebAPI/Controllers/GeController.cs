using Business.@interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeController : ControllerBase
    {

        private readonly IGeSer _geSer;
        public GeController(IGeSer geSer)
        {
            _geSer = geSer;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _geSer.GetAll() );
        }
    }
}
