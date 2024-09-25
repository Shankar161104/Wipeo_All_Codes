using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_AutoImplemented_and_getset
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer objCustomer = new Customer() 
            {
               CustomerID=1,CustomerName="shankar",CustomerEmail="shankarrentikota6@gmail.com",CustomerAddress="Vishakapatnam",
               CustomerSalary=30000,CustomerDesignation="software developer"
            
            
            };
            Console.WriteLine($"CustomerID::{objCustomer.CustomerID}  CustomerName::{objCustomer.CustomerName}  CustomerEmail::{objCustomer.CustomerEmail}  CustomerAddress::{objCustomer.CustomerAddress}  CustomerAddress::{objCustomer.CustomerAddress}  CustomerSalary::{objCustomer.CustomerSalary}");
            Console.ReadLine();

        }
    }

    public class Customer
    {

        private float _customerSalary;
        private string _customerAddress;
        private string _customerCity;
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }

        public float CustomerSalary {
            get { return _customerSalary; }
            set { _customerSalary = value; }
        
        }

        public string CustomerAddress
        {
            get { return _customerAddress; }
            set { _customerAddress = value; }
        
        }

        public string CustomerDesignation
        {
            get { return _customerCity; }
            set { _customerCity = value; }
        
        }

    }
}
