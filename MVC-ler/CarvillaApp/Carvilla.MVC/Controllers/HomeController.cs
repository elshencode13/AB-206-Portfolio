using Carvilla.DAL.Contexts;
using Carvilla.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carvilla.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
            List<CarsModel> carsModels = _context.CarsModels.ToList();
            return View(carsModels);
        }
    }
}
