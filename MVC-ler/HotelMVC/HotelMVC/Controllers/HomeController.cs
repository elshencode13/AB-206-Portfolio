using Microsoft.AspNetCore.Mvc;

namespace HotelMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
