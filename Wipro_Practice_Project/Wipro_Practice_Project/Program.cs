using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            List<Employee> lstemployee = new List<Employee>();
            Console.WriteLine("Enter the Employee details");
            Console.WriteLine("Enter Employee ID");
            int EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string EmployeeName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Employee Address");
            string EmployeeAddress = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter Employee Contact");
            float EmployeePhone = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Email");
            string EmployeeEmail = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the number of departments the employee works");

            List<Department> lstDept = new List<Department>();

            int NoOfDept = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= NoOfDept; i++)
            {
                Console.WriteLine("Enter the Department name");
                string DeptName = Convert.ToString(Console.ReadLine());

                Department objDepartment = new Department();
                objDepartment.DepartmentName = DeptName;
                lstDept.Add(objDepartment);


            }
            Employee objEmployee = new Employee()
            {
                EmployeeID=EmployeeID,
                EmployeeName=EmployeeName,
                EmployeeAddress=EmployeeAddress,
                EmployeeContact=EmployeePhone,
                EmployeeEmail=EmployeeEmail,
                Lstdept=lstDept   
            };
            lstemployee.Add(objEmployee);
            foreach(var emp in lstemployee)
            {
                Console.WriteLine($"Employee_ID::{emp.EmployeeID}  Employee_Name::{emp.EmployeeName}  Employee_Address::{emp.EmployeeAddress}  Employee_Phone::{emp.EmployeeContact}  Employee_Email::{emp.EmployeeEmail}");
                foreach (var dep in emp.Lstdept)
                {
                    Console.WriteLine($"Department List::{dep.DepartmentName}");
                }
            
            }







            Console.ReadLine();
            goto start;
        }
    }

    
    
}
