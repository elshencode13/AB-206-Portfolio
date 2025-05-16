using Microsoft.AspNetCore.Mvc;

namespace Carvilla.MVC.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
