using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Static_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company.DisplayCompany(1,"shankar","usa");

            //Company.companyID = 1;
            //Company.companyName = "WIPRO";
            //Company.companyAddress = "UGANDA";

            //Console.WriteLine($"CompanyID::{Company.companyID}  Companyname::{Company.companyName}  CompanyAddress::{Company.companyAddress}");
            Console.ReadLine();
        }

    }
}
