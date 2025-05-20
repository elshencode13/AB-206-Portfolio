using Microsoft.AspNetCore.Mvc;

namespace VillaApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
