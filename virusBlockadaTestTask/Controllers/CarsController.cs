using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using virusBlockadaTestTask.Assemblers;
using virusBlockadaTestTask.ViewModels;

namespace virusBlockadaTestTask.Controllers
{
    public class CarsController: Controller
    {
        private readonly ICarService _carService;

        public CarsController()
        {
            _carService = new CarService();
        }

        public ActionResult GetCarsList()
        {
            var result = _carService.GetAllCars().Select(CarViewModelAssembler.FromModelToViewModel).ToList();
            return PartialView(result);
        }

        [Authorize]
        [HttpPost]
        public  ActionResult AddCar(CarViewModel car)
        {
            if (ModelState.IsValid)
            {
                _carService.AddCar(CarViewModelAssembler.FromViewModelToModel(car));
                TempData["Sucess"] = "Машина успешно добавлена";
                return RedirectToAction("Index", "Home");
            }
            return View(car);
        }

        [Authorize]
        [HttpGet]
        public ActionResult AddCar()
        {
            return View();
        }
    }
}