using Autimarket.Services.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AutoMarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        public IActionResult GetCars()
        {

            var responce = _carService.GetCars();

            if (responce.StatusCode == Automarket.Domain.Response.StatusCode.OK)
            {
                return View(responce.Data);
            }

            return RedirectToAction("Error");
            
        }

        [HttpGet]
        public IActionResult GetCar(int id)
        {
            var responce = _carService.GetCarById(id);

            if (responce.StatusCode == Automarket.Domain.Response.StatusCode.OK)
            {
                return View(responce.Data);
            }

            else
            {
                return RedirectToAction("Error");
            }
        }

        [Authorize(Roles = "Admin")]
        public IActionResult DeleteCar(int id)
        {
            var responce = _carService.DeleteCar(id);

            if (responce.StatusCode == Automarket.Domain.Response.StatusCode.OK)
            {
                return RedirectToAction("GetCars");
            }

            return RedirectToAction("Error");
        }

        [HttpGet]
        public IActionResult Save(int id)
        {
            if (id == 0)
            {
                return View();
            }

            var responce = _carService.GetCarById(id);

            if (responce.StatusCode == Automarket.Domain.Response.StatusCode.OK)
            {
                return View(responce.Data);
            }

            return RedirectToAction("Error");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Save(CarViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Id == 0)
                {
                    _carService.CreateCar(model);
                }
                else
                {
                    _carService.Edit(model.Id,model);
                }
            }

            return RedirectToAction("GetCars");
        }
    }
}
