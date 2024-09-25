using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Three_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Company
    {
        public int companyID;
        public string companyName;
        public string companyAddress;

         static Company()
        {
            Console.WriteLine("Static constructor");
        }

        public Company(int _companyID, string _companyName, string _companyAddress) 
        {
            companyID = _companyID;
            companyName = _companyName;
            companyAddress = _companyAddress;

        }

        public Company()
        {
            Console.WriteLine("Default constructor invoked");
        }
    }
}
