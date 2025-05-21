using Microsoft.AspNetCore.Mvc;
using ViIla.DAL.Contexts;
using ViIla.DAL.Models;

namespace VillaApp.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            List<VillaModel> villaModels = _context.villaModels.ToList();
            return View();
        }
    }
}
