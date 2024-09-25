using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Static_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company.companyID = 1;
            Company.companyName = "WIPRO";
            Company.companyAddress = "Bangalore";

            Console.WriteLine($"Company_ID::{Company.companyID}   Company_Name::{Company.companyName}   Company_address::{Company.companyAddress}");
            Console.ReadLine();


        }
    }
}
