using AutoShop_Data.Interfaces;
using AutoShop_Data.MemoryDb;
using AutoShop_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoShop_Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAll()
        {
            return InMemoryDb.EmployeeData;
        }

        public int[] GetAllSoldCardIdsByEmployee(int employeeId)
        {
            return InMemoryDb.EmployeeData
                .FirstOrDefault(x => x.Id == employeeId)
                .SoldCardIds;
        }
    }
}
