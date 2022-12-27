using Autimarket.Services.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
using AutoMarket.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autimarket.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IBaseResponse<IEnumerable<Car>> GetAllCars()
        {
            BaseResponse<IEnumerable<Car>> baseResponse = new BaseResponse<IEnumerable<Car>>();

            try
            {
                var cars = _carRepository.Select();
                if (cars.ToList().Count == 0)
                {
                    baseResponse.Descroprion = "Найдено 0 элементов ";
                    baseResponse.StatusCode = StatusCode.Ok;

                }

                baseResponse.Data = cars;
            }
            catch (Exception ex)
            {

                throw;
            }

            return baseResponse;
        }
    }
}
