using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Class_and_Object_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.empId = 1;
            objEmployee.name = "shankar";
            objEmployee.contact = "7893668421";
            objEmployee.salary = 12000;
            objEmployee.age = 22;
            Console.WriteLine($"Emp ID::{objEmployee.empId}  Name::{objEmployee.name}  Contact::{objEmployee.contact}  Salary::{objEmployee.salary}  Age::{objEmployee.age}");
         

            Employee objEmployee1 = new Employee();
            objEmployee1.empId = 2;
            objEmployee1.name = "pratyush";
            objEmployee1.contact = "23143534";
            objEmployee1.salary = 1200000;
            Console.WriteLine($"Emp ID::{objEmployee1.empId}  Name::{objEmployee1.name}  Contact::{objEmployee1.contact}  Salary::{objEmployee1.salary}");

            Console.ReadLine();
        }
        public class Employee
        {
        public int empId;
        public string name;
        public string contact;
        public float salary;
            public int age;
        }
    }
}
