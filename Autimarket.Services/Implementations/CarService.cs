using Autimarket.Services.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
using AutoMarket.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Autimarket.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public IBaseResponse<IEnumerable<Car>> GetCars()
        {
            BaseResponse<IEnumerable<Car>> baseResponse = new BaseResponse<IEnumerable<Car>>();

            try
            {
                var cars = _carRepository.Select();

                if (cars.ToList().Count == 0)
                {
                    baseResponse.Descriprion = "Найдено 0 элементов ";
                    baseResponse.StatusCode = StatusCode.OK;

                }
                baseResponse.StatusCode = StatusCode.OK;
                baseResponse.Data = cars;
            }
            catch (Exception ex)
            {

                return new BaseResponse<IEnumerable<Car>>
                {
                    Descriprion = $"[GetCars] : {ex.Message}",
                };
            }

            return baseResponse;
        }

        public IBaseResponse<Car> GetCarById(int id)
        {
            BaseResponse<Car> baseResponse = new BaseResponse<Car>();
            try
            {
                baseResponse.Data = _carRepository.Get(id);

                if (baseResponse.Data is null)
                {
                    baseResponse.Descriprion = "UserNotFound";
                    baseResponse.StatusCode = StatusCode.UserNotFoundException;
                }
            }
            catch (Exception ex)
            {

                baseResponse.Descriprion = $"[GetCarById] - {ex.Message}";
                
            }

            return baseResponse;
        }

        public IBaseResponse<Car> GetCarByName(string name)
        {
            BaseResponse<Car> baseResponse = new BaseResponse<Car>();
            try
            {
                baseResponse.Data = _carRepository.GetByName(name);

                if (baseResponse.Data is null)
                {
                    baseResponse.Descriprion = "UserNotFound";
                    baseResponse.StatusCode = StatusCode.UserNotFoundException;
                }
            }
            catch (Exception ex)
            {

                baseResponse.Descriprion = $"[GetCarById] - {ex.Message}";

            }

            return baseResponse;
        }

    }
}
