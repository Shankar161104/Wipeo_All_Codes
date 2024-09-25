using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ReadOnly_eg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wipro objEmployee = new Wipro();

            Console.WriteLine("=========FRESHER============");

            objEmployee.empDesignaton = "Software Engineer";
            objEmployee.empSalary = 500000;
            Console.WriteLine($"empID::{objEmployee.empID}  empName::{objEmployee.empName}  empDesignation::{objEmployee.empDesignaton}  empSalary::{objEmployee.empSalary}");


            Console.WriteLine("=========AFTER 2 YEARS============");

            Wipro objEmployee1 = new Wipro();

            objEmployee1.empDesignaton = "Sr.Software Engineer";
            objEmployee1.empSalary = 1000000;
            Console.WriteLine($"empID::{objEmployee1.empID}  empName::{objEmployee1.empName}  empDesignation::{objEmployee1.empDesignaton}  empSalary::{objEmployee1.empSalary}");


            Console.WriteLine("=========AFTER 7 YEARS============");

            Wipro objEmployee2 = new Wipro();

           

            objEmployee2.empDesignaton = "Teamlead";
            objEmployee2.empSalary = 2000000;
            Console.WriteLine($"empID::{objEmployee2.empID}  empName::{objEmployee2.empName}  empDesignation::{objEmployee2.empDesignaton}  empSalary::{objEmployee2.empSalary}");




            Console.ReadLine();


        }
    }

    public class Wipro
    {
        public readonly int empID=1;
        public readonly string empName="Shankar";
        public string empDesignaton;
        public long empSalary;
    }
}
