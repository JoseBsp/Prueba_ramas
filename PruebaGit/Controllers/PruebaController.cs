using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PruebaGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaController : ControllerBase
    {
        [HttpGet("Prueba")]
        public IActionResult Prueba()
        {
            string prueba = "prueba";
            return BadRequest();
        }
    }
}
