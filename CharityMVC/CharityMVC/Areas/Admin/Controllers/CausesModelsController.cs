using CharityMVC.Models;
using CharityMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace CharityMVC.Areas.Admin.Controllers
{
    public class CausesModelsController : Controller
    {
        private readonly CausesModelService _casusModelService;

        public CausesModelsController()
        {
            _casusModelService = new CausesModelService();
        }

        public IActionResult Index()
        {
          List<CausesModel> causesModels =  _casusModelService.GetAllCausesModel();

            return View(causesModels);
        }

        public IActionResult Create()
        {
            

            return View();
        }
    }
}
