using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_eg_17_08_2024
{
    public sealed class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public float CustomerNumber { get; set; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"Customer ID: {CustomerID}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Customer Address: {CustomerAddress}");
            Console.WriteLine($"Customer Number::{CustomerNumber}");
        }


        private Customer()
        {

        }

        private static Customer Instance = null;
        public static Customer GetCustomer 
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new Customer();
                }
                return Instance;
            }
        }
    }
}
