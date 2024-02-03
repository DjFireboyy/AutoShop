using AutoShop_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Data.MemoryDb
{
    public static class InMemoryDb
    {
        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Brand = "",
                Model = "",
                Power = 1,
                EngineSize = 1,
                Price = 10000.50,
            },
            new Car()
            {
                Id = 2,
                Brand = "",
                Model = "",
                Power = 1,
                EngineSize = 1,
                Price = 10000.50,
            },
            new Car()
            {
                Id = 3,
                Brand = "",
                Model = "",
                Power = 1,
                EngineSize = 1,
                Price = 10000.50,
            },
        };

        public static List<Employee> EmployeeData =
            new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Employee 1",
                    Rank = 3,
                    CountOfsoldCars = 12,
                    SoldCardIds = new int[3] {1,2,3}
                },
                new Employee()
                {
                    Id = 1,
                    Name = "Employee 2",
                    Rank = 0,
                    CountOfsoldCars = 12
                },
                new Employee()
                {
                    Id = 1,
                    Name = "Employee 3",
                    Rank = 0,
                    CountOfsoldCars = 12,
                },
            };
    }
}
