using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_List_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployee = new List<Employee>();
            Employee objEmployee1 = new Employee();
            objEmployee1.EmpID = 1;
            objEmployee1.EmpName="Shankar";
            objEmployee1.EmpSalary = 23456.5f;
            listEmployee.Add(objEmployee1);

            Employee objEmployee2 = new Employee();
            objEmployee2.EmpID = 2;
            objEmployee2.EmpName = "Jai";
            objEmployee2.EmpSalary = 123456;
            listEmployee.Add(objEmployee2);

            Employee objEmployee3 = new Employee();
            objEmployee3.EmpID = 3;
            objEmployee3.EmpName = "Swaroop";
            objEmployee3.EmpSalary = 123453456;
            listEmployee.Add(objEmployee3);

            foreach (Employee objemployee in listEmployee)
            {
                Console.WriteLine($"EmpID:: {objemployee.EmpID}   EmpName:: {objemployee.EmpName}   EmpSalary:: {objemployee.EmpSalary}  ");
            }

            Console.ReadLine();
        }
    }
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary { get; set; }


    }
}
