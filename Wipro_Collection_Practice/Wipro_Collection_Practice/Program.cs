using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Department> lstdepartment = new List<Department>();
           
            Department objDepartment1 = new Department();
            objDepartment1.DeptID = 1;
            objDepartment1.DeptName = "IT";
            lstdepartment.Add(objDepartment1);

            Department objDepartment2 = new Department();
            objDepartment2.DeptID = 2;
            objDepartment2.DeptName = "HR";
            lstdepartment.Add(objDepartment2);


           


            List<Employeecs> lstEmployee = new List<Employeecs>();

            Employeecs objEmployee1 = new Employeecs()
            {
                EmpID = 101,
                EmpName = "Shankar",
                EmpSalary = 20000,
                EmpDesignation = "Teacher",
                lstDept=lstdepartment
            };
            lstEmployee.Add(objEmployee1);

            Employeecs objEmployee2 = new Employeecs()
            {
                EmpID = 102,
                EmpName = "Jai",
                EmpSalary = 30000,
                EmpDesignation = "Principal",
                lstDept = lstdepartment
            };
            lstEmployee.Add(objEmployee2);




            foreach (var objemployee in lstEmployee)
            {
                Console.WriteLine($"EmpID::{objemployee.EmpID}  EmpName::{objemployee.EmpName}  EmpSalary::{objemployee.EmpSalary}  EmpDesignation::{objemployee.EmpDesignation}  ");

                Console.WriteLine($"Employee::{objemployee.EmpName}  would be in this respective departments");
                foreach(var department in objemployee.lstDept)
                {
                    Console.WriteLine($"DeptID::{department.DeptID}  DeptName::{department.DeptName}");
                }
            }
            Console.ReadLine();




        }
    }
}
