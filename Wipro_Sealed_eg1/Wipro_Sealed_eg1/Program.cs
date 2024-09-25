using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Sealed_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerDetails objCustomer = new CustomerDetails()
            {
                CustomerID=1,CustomerName="Shankar",CustomerPhone=2354235
            };
            objCustomer.Info();
            

        }
    }
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int CustomerPhone { get; set; } 
    }

    public sealed class CustomerDetails:Customer
    {
        public string Info()
        {
            return "Info method from sealedd class, as a seakled class can inherit normal classes";
        }
    }
}
