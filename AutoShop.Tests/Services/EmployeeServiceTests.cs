using AutoShop_Data.Interfaces;
using AutoShop_Models.Models;
using AutoShop_Services.Interfaces;
using AutoShop_Services.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace AutoShop.Tests.Services
{
    public class EmployeeServiceTests
    {
        public static List<Car> CarData = new List<Car>()
        {
            new Car()
            {
                Id = 1,
                Brand = "Car 1",
                Model = "Model 1",
                Price = 10.10,
                EngineSize = 100,
                Power = 10
            },
            new Car()
            {
                Id = 2,
                Brand = "Car 2",
                Model = "Model 2",
                Price = 20.20,
                EngineSize = 200,
                Power = 20
            },
            new Car()
            {
                Id = 3,
                Brand = "Car 3",
                Model = "Model 3",
                Price = 30.30,
                EngineSize = 300,
                Power = 30
            },
        };

        public static List<Employee> EmployeeData =
            new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    Name = "Employee 1",
                    Rank = 1,
                    CountOfsoldCars = 2,
                    SoldCardIds = new int [2] {1,2}
                },
                new Employee()
                {
                    Id = 2,
                    Name = "Employee 2",
                    Rank = 3,
                    CountOfsoldCars = 0,
                    SoldCardIds = new int [0]
                },
            };

        private Mock<IEmployeeRepository> mockEmployeeRepository;
        private Mock<ICarRepository> mockCarRepository;
        private readonly IEmployeeService employeeService;

        public EmployeeServiceTests()
        {
            this.mockCarRepository = new Mock<ICarRepository>();
            this.mockEmployeeRepository = new Mock<IEmployeeRepository>();
            this.employeeService = new EmployeeService(
                                    this.mockEmployeeRepository.Object,
                                    this.mockCarRepository.Object
                                  );
        }

        [Fact]
        public void GetEmployeeWithTheHighRank_Ok()
        {
            //setup
            var expectedEmployee = EmployeeData.Last();

            this.mockEmployeeRepository.Setup(
                x =>
                    x.GetAll())
                .Returns(EmployeeData);


            //act
            var result = this.employeeService.GetEmployeeWithTheHighRank();

            //Assert
            Assert.Equal(expectedEmployee.Name, result.Name);
            Assert.Equal(expectedEmployee.Rank, result.Rank);
            Assert.Equal(expectedEmployee.SoldCardIds.Length, result.SoldCardIds.Length);
        }


    }
}
