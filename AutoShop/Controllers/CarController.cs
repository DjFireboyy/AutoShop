using AutoShop_Models.Models;
using AutoShop_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        // GET: api/<CarController>
        [HttpGet("GetAll")]
        public IEnumerable<Car> GetAll()
        {
            return this.carService.GetAll();
        }

        // GET api/<CarController>/5
        [HttpGet("GetById")]
        public Car GetById(int id)
        {
            Car car = this.carService.GetById(id);

            if (car == null)
            {
                return new Car();
            }

            return car;
        }

        // POST api/<CarController>
        [HttpPost("Add")]
        public void Add([FromBody] Car car)
        {
            this.carService.Add(car);
        }

        // DELETE api/<CarController>/5
        [HttpDelete("Delete")]
        public void Delete(int id)
        {
            this.carService.Delete(id);
        }
    }
}
