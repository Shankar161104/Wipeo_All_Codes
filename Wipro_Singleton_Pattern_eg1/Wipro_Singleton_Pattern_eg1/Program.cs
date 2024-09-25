using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Pattern_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = Employee.CreateObject();
            objEmployee.EmpID = 1;
            objEmployee.EmpName = "Shankar";
            objEmployee.EmpSalary = 23425.4f;
            Console.WriteLine($"Employee_ID::{objEmployee.EmpID}  Employee_Name::{objEmployee.EmpName}  Employee_Salary::{objEmployee.EmpSalary}");


            Employee objEmployee1 = Employee.CreateObject();
            objEmployee1.EmpID = 2;
            objEmployee1.EmpName = "Jai";
            objEmployee1.EmpSalary = 2344345f;
            Console.WriteLine($"Employee_ID::{objEmployee1.EmpID}  Employee_Name::{objEmployee1.EmpName}  Employee_Salary::{objEmployee1.EmpSalary}");

            Console.ReadLine();
        }
    }
}
