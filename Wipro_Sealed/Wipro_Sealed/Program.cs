using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Sealed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee()
            {
                EmpID=1,EmpName="Shankar",EmpSal=230000
            };
            Console.WriteLine($"Employee_ID::{objEmployee.EmpID}");
            Console.ReadLine();

        }
    }

    public sealed class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSal { get; set; }
    }

    public class EmployeeDetails:Employee
    {
        //cannot perfoem inheritance on sealed class
    }
}
