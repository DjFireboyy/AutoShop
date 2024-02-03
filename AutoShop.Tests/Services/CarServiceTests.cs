using AutoShop_Data.Interfaces;
using AutoShop_Models.Models;
using AutoShop_Services.Interfaces;
using AutoShop_Services.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace AutoShop_Tests.Services
{
    public class CarServiceTests
    {
        private ICarService carService;

        private readonly Mock<ICarRepository> mockCarRepository;

        public CarServiceTests()
        {
            this.mockCarRepository = new Mock<ICarRepository>();
            this.carService = new CarService(this.mockCarRepository.Object);
        }
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

        
        [Fact]
        public void GetAll_Ok()
        {
            //setup
            var expectedCount = 3;

            this.mockCarRepository.Setup(
                x =>
                    x.GetAll())
                .Returns(CarData);

            //act
            var result = this.carService.GetAll();

            //Assert
            Assert.Equal(expectedCount,result.Count);
        }

        [Fact]
        public void GetById_Ok()
        {
            //setup
            var expectedCar = new Car()
            {
                Id = 2,
                Brand = "Car 2",
                Model = "Model 2",
                Price = 20.20,
                EngineSize = 200,
                Power = 20
            };

            this.mockCarRepository.Setup(
                x =>
                    x.GetById(expectedCar.Id))
                .Returns(expectedCar);

            //act
            var result = this.carService.GetById(expectedCar.Id);

            //Assert
            Assert.Equal(expectedCar.Brand, result.Brand);
            Assert.Equal(expectedCar.Model, result.Model);
            Assert.Equal(expectedCar.Price, result.Price);
        }

        [Fact]
        public void GetById_WithInvalidId_ReturnNull()
        {
            //setup
            var expectedCar = new Car()
            {
                Id = 2,
                Brand = "Car 2",
                Model = "Model 2",
                Price = 20.20,
                EngineSize = 200,
                Power = 20
            };

            //act
            var result = this.carService.GetById(-12);

            //Assert
            Assert.Null(result);
        }
    }
}
