using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Static_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Company.companyID = 1;
            Company.companyName = "WIPRO";
            Company.companyAddress = "GURGAON";
            Console.WriteLine($"Company_ID::{Company.companyID},Company_Name::{Company.companyName}  Company_Address::{Company.companyAddress}");

            Company.companyID = 2;
            Company.companyName = "WIPRO";
            Company.companyAddress = "NOIDA";
            Console.WriteLine($"Company_ID::{Company.companyID},Company_Name::{Company.companyName}  Company_Address::{Company.companyAddress}");

            Company.companyID = 3;
            Company.companyName = "WIPRO";
            Company.companyAddress = "BANGALORE";
            Console.WriteLine($"Company_ID::{Company.companyID},Company_Name::{Company.companyName}  Company_Address::{Company.companyAddress}");



            Console.ReadLine();

        }
    }
    public class Company
    {
        public static int companyID;
        public static string companyName;
        public static string companyAddress;
        static Company()
        {
            Console.WriteLine("Static constructor called");
        }
    }
}
