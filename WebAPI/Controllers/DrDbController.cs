using Business;
using Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DrDbController : ControllerBase
    {

        public DrDbController()
        {

        }
        [HttpGet]
        public async Task<List<Doktorlar>> GetDocks()
        {

            List<Doktorlar> dr=await new DrBus().GetAllDoctors();
            return dr;

           /* String a = string.Empty;
            Task<List<Doktorlar>> doctors = new DrBus().GetAllDoctors();
            foreach (var item in doctors.Result)
            {
                a += item.Ad + " " + item.Soyad + " " + item.UzmanlikAlani + " " + item.TelefonNumarasi + "\n";
            }

            return a;*/
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDocksId(int id)
        {

            var D = await new DrBus().GetDoctorById(id);

            if (D != null)
            {
                return Ok(D);
            }
            return NotFound();


            /*Doktorlar doctor = await new DrBus().GetDoctorById(id);
            String a = doctor.Ad + " " + doctor.Soyad + " " + doctor.UzmanlikAlani + " " + doctor.TelefonNumarasi;
            return a;*/

        }
        [HttpPost]
        public IActionResult AddDoc([FromBody] Doktorlar data)
        {

            if (ModelState.IsValid)
            {
                new DrBus().AddDoctor(data);
                return Ok("başarılı");
            }


            return BadRequest("Patient added successfully");



            /*await new DrBus().AddDoctor(data);
            return "Doctor added successfully";*/

        }
    }
}
