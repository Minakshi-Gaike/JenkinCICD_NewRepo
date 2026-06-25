using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JenkinCICD.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        [HttpGet]
        [Route("api/state")]
        public IActionResult GetState()
        {
            return Ok("Application is running successfully.");
        }
    }
}
