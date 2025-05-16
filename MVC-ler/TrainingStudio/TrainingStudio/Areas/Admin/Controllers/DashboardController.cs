using Microsoft.AspNetCore.Mvc;
using TrainingStudio.Contexts;

namespace TrainingStudio.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController()
        {
            _context = new AppDbContext();
        }
        public IActionResult Index()
        {
          var programs =  _context.ProgramModels.ToList();
            return View(programs);
        }
    }
}
