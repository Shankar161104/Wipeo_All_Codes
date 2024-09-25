using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ReadOnly_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wipro objEmployee = new Wipro();
            objEmployee.empID = 1;
            objEmployee.empName = "Shankar";
            objEmployee.empDesignaton = "Software Engineer";
            objEmployee.empSalary = 500000;
            Console.WriteLine($"empID::{objEmployee.empID}  empName::{objEmployee.empName}  empDesignation::{objEmployee.empDesignaton}  empSalary::{objEmployee.empSalary}");


            Wipro objEmployee1 = new Wipro();
            objEmployee1.empID = 1;
            objEmployee1.empName = "Shankar";
            objEmployee1.empDesignaton = "Sr.Software Engineer";
            objEmployee1.empSalary = 1000000;
            Console.WriteLine($"empID::{objEmployee.empID}  empName::{objEmployee.empName}  empDesignation::{objEmployee.empDesignaton}  empSalary::{objEmployee.empSalary}");




            Console.ReadLine();


        }
    }

    public class Wipro
    {
        public int empID;
        public string empName;
        public string empDesignaton;
        public long empSalary;
    }
}
