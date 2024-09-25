using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Get_and_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee()
            {
                EmpID=1,EmpName="Shankar",EmpAddress="Vizianagaram"
            };
            Console.WriteLine($"Emp_ID::{objEmployee.EmpID}  Emp_Name::{objEmployee.EmpName}  Emp_Address::{objEmployee.EmpAddress}");

            Console.ReadLine();
        }
    }
}
