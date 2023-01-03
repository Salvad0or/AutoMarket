using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
using Automarket.Domain.ViewModels.Car;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autimarket.Services.Interfaces
{
    public interface ICarService    
    {
        IBaseResponse<IEnumerable<Car>> GetCars();

        IBaseResponse<Car> GetCarById(int id);

        IBaseResponse<Car> GetCarByName(string name);

        IBaseResponse<bool> DeleteCar(int id);

        IBaseResponse<CarViewModel> CreateCar(CarViewModel carViewModel);

        IBaseResponse<Car> Edit(int id, CarViewModel model);


    }
}
