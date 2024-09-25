using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_27_08_2024
{
    public class CustomerOrder
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string OrderHistory { get; set; }
        public string Reviews { get; set; }
        public string OrderProduct { get; set; }
        public int TotalAmount { get; set; }
    }
}
