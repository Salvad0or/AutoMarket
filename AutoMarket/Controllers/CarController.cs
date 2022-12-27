using Autimarket.Services.Interfaces;
using AutoMarket.Dal.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
            var responce = _carService.GetAllCars();
            return View(responce);
        }
    }
}
