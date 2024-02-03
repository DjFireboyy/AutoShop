using AutoShop_Data.Interfaces;
using AutoShop_Models.Models;
using AutoShop_Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop_Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRepository;
        private ICarRepository carRepository;

        public EmployeeService(
            IEmployeeRepository employeeRepository,
            ICarRepository carRepository
        ) {
            this.employeeRepository = employeeRepository;
            this.carRepository = carRepository;
        }

        public List<Car> GetAllSoSoldCardByEmployee(int employeeId)
        {
            List<Car> soldCars = new List<Car>();

            int[] soldCardIds = this.employeeRepository
                                        .GetAllSoldCardIdsByEmployee(employeeId);

            if (soldCardIds.Length == 0)
            {
                return soldCars;
            }

            foreach (int id in soldCardIds)
            {
                Car car = this.carRepository.GetById(id);

                if (car == null) { continue;}

                soldCars.Add(car);
            }

            return soldCars;
        }

        public Employee GetEmployeeWithTheHighRank()
        {
            return this.employeeRepository.GetAll()
                .OrderByDescending(x => x.Rank)
                .FirstOrDefault();
        }
    }
}
