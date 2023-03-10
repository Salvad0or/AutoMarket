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
            try
            {
                _db.Cars.Remove(entity);
                _db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public Car Get(int id)
        {
            return _db.Cars.FirstOrDefault(i => i.Id == id);
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

        public void Update(Car entity)
        {
            _db.Cars.Update(entity);

            _db.SaveChanges();
        }
    }
}
