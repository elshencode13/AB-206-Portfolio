using CharityMVC.Contexts;
using CharityMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CharityMVC.Controllers
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
            List<CausesModel> causesModels = _context.CausesModels.ToList();
            return View(causesModels);
        }
    }
}
