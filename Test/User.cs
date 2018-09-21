using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class User
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }

        public List<Order> Orders { get; set; }
    }
}
