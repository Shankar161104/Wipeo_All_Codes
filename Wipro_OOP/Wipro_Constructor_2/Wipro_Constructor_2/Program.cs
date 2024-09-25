using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Constructor_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***********CUSTOMER 1******************");
            Customer customer1 = new Customer();
            customer1.custID = 101;
            customer1.custName = "Shankar";
            customer1.custAddress = "fawerfawerf";
            customer1.custEmail = "shankarrentikota6@gmail.com";

            Console.WriteLine($"Customer_ID::{customer1.custID}   Customer_name::{customer1.custName}   Customer_Address::{customer1.custAddress}   Customer_email::{customer1.custEmail}");
            Console.ReadLine();

        }
    }
    public class Customer
    {
        public int custID;
        public string custName;
        public string custAddress;
        public string custEmail;
        public Customer()
        {
            Console.WriteLine("Customer constructor invoked");
        }
    }
}
