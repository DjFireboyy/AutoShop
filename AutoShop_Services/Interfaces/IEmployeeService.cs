using AutoShop_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Car> GetAllSoSoldCardByEmployee(int employeeId);

        Employee GetEmployeeWithTheHighRank();
    }
}
