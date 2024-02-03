using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Models.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Rank { get; set; }

        public int CountOfsoldCars { get; set; }

        public int[] SoldCardIds { get; set; }

    }
}
