using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_StartcConstructor_with_NormalClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company();
            objCompany.companyID = 1;
            objCompany.companyName = "VELTECH";
            objCompany.companyAddress = "INDIA";

            Console.WriteLine($"Company_ID::{objCompany.companyID}  Company_Name::{objCompany.companyName}  Company_Adress::{objCompany.companyAddress}");



            Company objCompany2 = new Company();
            objCompany.companyID = 2;
            objCompany.companyName = "REPOS";
            objCompany.companyAddress = "INDIA";

            Console.WriteLine($"Company_ID::{objCompany2.companyID}  Company_Name::{objCompany2.companyName}  Company_Adress::{objCompany2.companyAddress}");
            Console.ReadLine();
        }
    }

    public class Company
    {
        public int companyID;
        public string companyName;
        public string companyAddress;

        public Company()
        {
            Console.WriteLine("Default Constructor Invoked");
            int c = 0;
            c++;
        }
         static Company()
        {
            Console.WriteLine("Static Constructor Invoked");
            
        }
    }
}
