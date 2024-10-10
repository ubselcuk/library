using Microsoft.AspNetCore.Mvc;

namespace ubselcuk.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
