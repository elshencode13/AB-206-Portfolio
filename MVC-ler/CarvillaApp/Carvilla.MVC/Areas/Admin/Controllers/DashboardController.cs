using Carvilla.DAL.Contexts;
using Carvilla.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carvilla.MVC.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController()
        {
            _context = new AppDbContext();
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Tables()
        {
            List<CarsModel> carsModels = _context.CarsModels.ToList();
            return View(carsModels);
        }
    }
}
