using AutoMarket.Dal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AutoMarket.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;

        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IActionResult GetCarById()
        {

            return View(_carRepository.Get(1));
        }
    }
}
