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
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("GetEmployeeWithTheHighRank")]
        public Employee GetEmployeeWithTheHighRank()
        {
            var employee = this.employeeService.GetEmployeeWithTheHighRank();

            if (employee == null)
            {
                return new Employee();
            }

            return employee;
        }

        [HttpPost("GetAllSoSoldCardByEmployee")]
        public IEnumerable<Car> GetAllSoSoldCardByEmployee([FromBody] int employeeId)
        {
            return this.employeeService.GetAllSoSoldCardByEmployee(employeeId);
        }
    }
}
