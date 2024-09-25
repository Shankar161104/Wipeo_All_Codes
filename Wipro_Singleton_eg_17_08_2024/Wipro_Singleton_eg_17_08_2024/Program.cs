using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_eg_17_08_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer.GetCustomer.CustomerID = 1;
            Customer.GetCustomer.CustomerName = "Shankar";
            Customer.GetCustomer.CustomerAddress = "Vizianagaram";
            Customer.GetCustomer.CustomerNumber = 7893668421;

            Customer.GetCustomer.DisplayCustomerDetails();
        }
    }
}
