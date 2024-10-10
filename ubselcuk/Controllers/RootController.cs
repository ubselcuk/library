using Microsoft.AspNetCore.Mvc;

namespace ubselcuk.Controllers
{
    public class RootController : Controller
    {
        private readonly ILogger<RootController> _logger;

        public RootController(ILogger<RootController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Index Called");
            return View();
        }
    }
}
