using AutoShop_Data.Interfaces;
using AutoShop_Data.MemoryDb;
using AutoShop_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop_Data.Repositories
{
    public class CarRepository : ICarRepository
    {
        public void Add(Car car)
        {
            InMemoryDb.CarData.Add(car);
        }

        public void Delete(int id)
        {
            Car car = GetById(id);

            if (car != null)
            {
                InMemoryDb.CarData.Remove(car);
            }
        }

        public List<Car> GetAll()
        {
            return InMemoryDb.CarData;
        }

        public Car GetById(int id)
        {
            return InMemoryDb.CarData
                 .FirstOrDefault(a => a.Id == id);
        }
    }
}
