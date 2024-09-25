using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Dependency_Practice_17_08_2024
{
    public class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary { get; set; }
        public string EmpCity { get; set; }
         Department department { get; set; }
        public Employee(Department _department,int _empID,string _empName, float _empSalary,string _empCity)
        {
            department = _department;
            EmpID = _empID;
            EmpName = _empName;
            EmpSalary = _empSalary;
            EmpCity = _empCity;

        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Employee Name: {EmpName}");
            Console.WriteLine($"Employee Salary: {EmpSalary}");
            Console.WriteLine($"Employee City: {EmpCity}");
            Console.WriteLine($"Department ID: {department.DeptID}");
            Console.WriteLine($"Department Name: {department.DeptName}");
        }

    }

    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public Department(int _deptID, string _deptName)
        {
            DeptID = _deptID;
            DeptName = _deptName;
        }
    }
}
