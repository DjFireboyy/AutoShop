using AutoShop_Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Data.Interfaces
{
    public interface IEmployeeRepository
    {
        int[] GetAllSoldCardIdsByEmployee(int employeeId);

        List<Employee> GetAll();
    }
}
