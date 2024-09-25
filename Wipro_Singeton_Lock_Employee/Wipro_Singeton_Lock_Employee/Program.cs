using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singeton_Lock_Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = Employee.Instance;
            objEmployee.EmpID = 1;
            objEmployee.EmpName = "Shankar";
            objEmployee.EmpSalary = 5446;
            Console.WriteLine($"Employee_ID::{objEmployee.EmpID}  Employee_Name::{objEmployee.EmpName}  Employee_Salary::{objEmployee.EmpSalary}");
            Console.ReadLine();
        }
    }
}
