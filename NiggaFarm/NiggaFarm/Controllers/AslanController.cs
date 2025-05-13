using Microsoft.AspNetCore.Mvc;

namespace NiggaFarm.Controllers
{
    public class AslanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
