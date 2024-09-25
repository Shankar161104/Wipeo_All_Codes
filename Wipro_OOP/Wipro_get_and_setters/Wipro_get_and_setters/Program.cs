using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_get_and_setters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee()
            {
                EmpID=101,EmpName="Geeta",EmpSalary=2000
            };
            Console.WriteLine($"EmpID::{objEmployee.EmpID}  EmpName::{objEmployee.EmpName}  EmpSalary::{objEmployee.EmpSalary}");
            Console.ReadLine();
        }
    }

    public class Employee
    {
        float _empSalary;
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary
        {
            get { return _empSalary; }
            set { _empSalary = value; }
        }
       
    }
}
