using Carvilla.BL.Services;
using Carvilla.BL.ViewModels;
using Carvilla.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace Carvilla.MVC.Areas.Admin.Controllers
{
    [Area("admin")]
    public class ServiceController : Controller
    {
        private readonly CarsModelServices _services;

        public ServiceController()
        {
            _services = new CarsModelServices();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CarsModelsCreateVM carsModelsCreateVM)
        {
            _services.Create(carsModelsCreateVM);

            return RedirectToAction("Tables","Dashboard");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            _services.Delete(id);
            return RedirectToAction("Tables", "Dashboard");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            CarsModel carsModel = _services.GetById(id);
            CarsModelUpdateVM carsModelUpdateVM = new CarsModelUpdateVM();

            carsModelUpdateVM.Name =carsModel.Name;
            carsModelUpdateVM.Model = carsModel.Model ;
            carsModelUpdateVM.Description = carsModel.Description ;
            carsModelUpdateVM.Mi = carsModel.Mi;
            carsModelUpdateVM.HP = carsModel.HP ;
            carsModelUpdateVM.Price = carsModel.Price ;

            return View(carsModelUpdateVM);
        }

        [HttpPost]
        public IActionResult Update(int id,CarsModelUpdateVM carsModelUpdateVM)
        {
            _services.Update(carsModelUpdateVM,id);
            return RedirectToAction("Tables", "Dashboard");
        }
    }
}
