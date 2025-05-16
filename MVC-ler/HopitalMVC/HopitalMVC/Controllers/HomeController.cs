using Microsoft.AspNetCore.Mvc;

namespace HopitalMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
