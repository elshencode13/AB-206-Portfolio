using CharityMVC.Contexts;
using CharityMVC.Models;
using CharityMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CharityMVC.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashboardController : Controller
    {
        private readonly CausesModelService _cauesesModelService;

        public DashboardController()
        {
            _cauesesModelService = new CausesModelService();
        }

        public IActionResult Index()
        {
            List<CausesModel> cauesesModels = _cauesesModelService.GetAllCausesModel();

            return View(cauesesModels);
        }



    }
}
