using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Autimarket.Services.Interfaces
{
    public interface ICarService    
    {
        IBaseResponse<IEnumerable<Car>> GetCars();
    }
}
