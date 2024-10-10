using Microsoft.AspNetCore.Mvc;

namespace ubselcuk.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
