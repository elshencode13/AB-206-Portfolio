using Carvilla.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carvilla.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<FeaturedCar> featuredCars = new List<FeaturedCar>();
            return View();
        }
    }
}
