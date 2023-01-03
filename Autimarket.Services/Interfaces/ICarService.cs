using Automarket.Domain.Entity;
using Automarket.Domain.Interfaces;
using Automarket.Domain.Response;
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
