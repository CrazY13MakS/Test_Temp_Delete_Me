using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class ManagerInfo
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public bool IsCompleted { get; set; }

        public Order Order { get; set; }

    }
}
