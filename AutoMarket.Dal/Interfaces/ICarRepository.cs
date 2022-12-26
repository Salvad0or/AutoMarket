using Automarket.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMarket.Dal.Interfaces
{
    public interface ICarRepository : IBaseRepository<Car>
    {
        Car GetByName(string name);
    }
}
