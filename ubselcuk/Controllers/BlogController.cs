using Microsoft.AspNetCore.Mvc;

namespace ubselcuk.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutThisWebsite()
        {
            return View("Post/AboutThisWebsite");
        }
    }
}
