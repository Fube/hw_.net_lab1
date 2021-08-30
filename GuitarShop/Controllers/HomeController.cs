using Microsoft.AspNetCore.Mvc;

namespace GuitarShop.Controllers
{
    public class HomeController : Controller
    {
        // Binds the view to the Home/Index action and /
        public IActionResult Index()
        {
            return View();
        }
        // Binds the view to the Home/About
        public IActionResult About()
        {
            return View();
        }
    }
}