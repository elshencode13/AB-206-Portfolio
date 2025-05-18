using Microsoft.AspNetCore.Mvc;

namespace Carvilla.MVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }
    }
}
