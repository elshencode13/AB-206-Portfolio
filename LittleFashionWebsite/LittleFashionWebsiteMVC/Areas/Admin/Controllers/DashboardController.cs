using Microsoft.AspNetCore.Mvc;

namespace LittleFashionWebsiteMVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
