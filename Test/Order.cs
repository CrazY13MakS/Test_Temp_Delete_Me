using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
   public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        
        public DateTime Date { get; set; }
        public String Adress { get; set; }
        public String City { get; set; }
        public String Country { get; set; }




        public virtual List<OrderCar> Cars { get; set; }





        public virtual User User { get; set; }
        public virtual ManagerInfo ManagerInfo { get; set; }
    }
}
