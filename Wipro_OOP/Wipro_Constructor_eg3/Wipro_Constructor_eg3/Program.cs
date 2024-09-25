using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Constructor_eg3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********DEFAULT CONSTRUCTOR**********");
            Employee employee1 = new Employee();
            employee1.empID = 1;
            employee1.empName = "Shankar";
            employee1.empAddress = "INDIA";
            employee1.empGender = "MALE";
            Console.WriteLine($"empID::{employee1.empID}  empName::{employee1.empName}  empAddress::{employee1.empAddress}  empGender::{employee1.empGender}");

            Console.WriteLine("********PARAMETERIZED CONSTRUCTOR**********");

            Employee employee2 = new Employee(2,"jai","USA","MALE");
            Console.WriteLine($"empID::{employee2.empID}  empName::{employee2.empName}  empAddress::{employee2.empAddress}  empGender::{employee2.empGender}");
            
            
            Console.ReadLine();

        }
    }
    public class Employee
    {
        public int empID;
        public string empName;
        public string empAddress;
        public string empGender;
        public Employee()
        {
            Console.WriteLine("Employee Default constructor invoked");
        }

        public Employee(int _empID, string _empName,string _empAddress,string _empGender)
        {
            empID = _empID;
            empName = _empName;
            empAddress = _empAddress;
            empGender = _empGender;
        }
    }
}
