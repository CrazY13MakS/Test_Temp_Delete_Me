using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
   public class OrderCar
    {
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int CarId { get; set; }
        public int Quantity { get; set; }



        public virtual Car Car { get; set; }
        public virtual Order Order { get; set; }
    }
}
