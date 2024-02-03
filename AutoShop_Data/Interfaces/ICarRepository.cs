using AutoShop_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Data.Interfaces
{
    public interface ICarRepository
    {
        List<Car> GetAll();
        
        Car GetById(int id);

        void Add(Car car);

        void Delete(int id);
    }
}
