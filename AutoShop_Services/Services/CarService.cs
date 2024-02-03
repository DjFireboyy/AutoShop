using AutoShop_Data.Interfaces;
using AutoShop_Models.Models;
using AutoShop_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Services.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository carRepository;

        public CarService(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }
        public void Add(Car car)
        {
            this.carRepository.Add(car);
        }

        public void Delete(int id)
        {
            this.carRepository.Delete(id);
        }

        public List<Car> GetAll()
        {
            return this.carRepository.GetAll();
        }

        public Car GetById(int id)
        {
            if (id <= 0) return null;

            return this.carRepository.GetById(id);
        }
    }
}
