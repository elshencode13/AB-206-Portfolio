using GYM.BL.Services;
using GYM.DAL.Contexts;
using GYM.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace GYM.MVC.Controllers
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
            List<ProductModel> productModels = _context.ProductModels.ToList();
            return View(productModels);
        }
    }
}
