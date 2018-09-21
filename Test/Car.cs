using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
   public class Car
    {
        public int Id { get; set; }

        public String Model { get; set; }

        public String Category { get; set; }

        public decimal Price { get; set; }

        public List<OrderCar> OrderCars { get; set; }
    }
}
