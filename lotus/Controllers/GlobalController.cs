using Microsoft.AspNetCore.Mvc;

namespace lotus.Controllers
{
    public class GlobalController : ControllerBase
    {
        [HttpGet]
        [Route("greet")]
        public IActionResult Greet()
        {
            return Ok("Hello There!");
        }
    }
}
