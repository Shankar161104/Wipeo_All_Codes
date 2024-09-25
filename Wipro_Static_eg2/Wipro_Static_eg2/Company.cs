using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Static_eg2
{
    public static class Company
    {
        public static int companyID;
        public static string companyName;
        public static string companyAddress;

        public static void DisplayCompany(int _companyID, string _companyName, string _companyAddress)
        {
            companyID = _companyID;
            companyName = _companyName;
            companyAddress = _companyAddress;
            Console.WriteLine($"CompanyID::{companyID}  CompanyName::{companyName}  ComapnyAddress::{companyAddress}");

        }
    }


}
