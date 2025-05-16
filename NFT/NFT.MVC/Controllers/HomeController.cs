using Microsoft.AspNetCore.Mvc;

namespace NFT.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
