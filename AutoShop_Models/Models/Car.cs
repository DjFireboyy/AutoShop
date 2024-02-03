using System;
using System.Collections.Generic;
using System.Text;

namespace AutoShop_Models.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Brand { get; set; } = string.Empty;

        public string Model { get; set; } = string.Empty;

        public double Price { get; set; }

        public int Power { get; set; }

        public int EngineSize { get; set; }
    }
}
