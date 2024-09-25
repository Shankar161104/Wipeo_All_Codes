using System;

namespace Wipro_Dependency_Injection_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee objEmployee = new Employee( new Department(101, "IT"), 1, "Shankar", 2354, "Software Engineer");

            Console.WriteLine($"Employee_ID: {objEmployee.EmpID}   Employee_Name: {objEmployee.EmpName}   Employee_Salary: {objEmployee.EmpSalary}   Employee_Designation: {objEmployee.EmpDesign}");
            Console.WriteLine($"Department_ID: {objEmployee.department.DeptID}   Department_Name: {objEmployee.department.DeptName}");

            Console.ReadLine();
        }
    }

    
    public class Employee
    {
        
        public Department department;

        public int EmpID;
        public string EmpName;
        public float EmpSalary;
        public string EmpDesign;

      
        public Employee(Department _department, int _empID, string _empName, float _empSalary, string _empDesign)
        {
            this.department = _department;
            EmpID = _empID;
            EmpName = _empName;
            EmpSalary = _empSalary;
            EmpDesign = _empDesign;
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
