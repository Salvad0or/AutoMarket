using Automarket.Domain.Entity;
using AutoMarket.Dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.Dal.Repositories
{
    public class CarRepository : ICarRepository
    {
        ApplicationDbContext _db;
        public CarRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(Car entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Car entity)
        {
            throw new NotImplementedException();
        }

        public Car Get(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> Select()
        {
            List<Car> cars = new List<Car>();

           
            cars = _db.Cars.ToList();
            

            return cars;
        }
    }
}
