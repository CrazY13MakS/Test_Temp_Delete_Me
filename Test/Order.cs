using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
   public class Order
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int Userid { get; set; }
        public DateTime Date { get; set; }
        public String Adress { get; set; }
        public String City { get; set; }
        public String Country { get; set; }
        public int Quantity { get; set; }





        public User User { get; set; }
        public Car Car { get; set; }
        public ManagerInfo ManagerInfo { get; set; }
    }
}
