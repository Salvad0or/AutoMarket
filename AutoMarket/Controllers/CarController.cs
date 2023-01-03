using Autimarket.Services.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
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
    }
}
