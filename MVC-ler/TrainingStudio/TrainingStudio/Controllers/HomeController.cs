using Microsoft.AspNetCore.Mvc;

namespace TrainingStudio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
