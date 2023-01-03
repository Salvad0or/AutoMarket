using Autimarket.Services.Interfaces;
using Automarket.Domain.Entity;
using Automarket.Domain.Enum;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;
using AutoMarket.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

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
                    baseResponse.Descriprion = "CarNotFoune";
                    baseResponse.StatusCode = StatusCode.CarNotFound;
                }
            }
            catch (Exception ex)
            {

                baseResponse.Descriprion = $"[GetCarByName] - {ex.Message}";

            }

            return baseResponse;
        }

        public IBaseResponse<bool> DeleteCar(int id)
        {
            BaseResponse<bool> baseResponse = new BaseResponse<bool>();
            try
            {
              
                Car car = _carRepository.Get(id);

                if (car is null)
                {
                    baseResponse.Descriprion = "UserNotFound";
                    baseResponse.StatusCode = StatusCode.UserNotFoundException;
                }

                baseResponse.Data = _carRepository.Delete(car);

            }
            catch (Exception ex)
            {

                baseResponse.Descriprion = $"[DeleteCar] - {ex.Message}";
            }
            return baseResponse;

        }

        public IBaseResponse<CarViewModel> CreateCar(CarViewModel carViewModel)
        {
            BaseResponse<CarViewModel> baseResponse = new BaseResponse<CarViewModel>();

            try
            {
                Car car = new Car
                {
                    Name = carViewModel.Name,
                    Description = carViewModel.Description,
                    Model = carViewModel.Model,
                    Speed = carViewModel.Speed,
                    Price = carViewModel.Price,
                    TypeCar = (TypeCar)Convert.ToInt32(carViewModel.TypeCar),

                };

                _carRepository.Create(car);

               
            }
            catch (Exception ex)
            {
                baseResponse.Descriprion = $"[CreateCar] - {ex.Message}";
            }

            return baseResponse;
            
        }

    }

    
}
