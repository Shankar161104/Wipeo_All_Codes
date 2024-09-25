using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_List_eg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> lstDepartment = new List<Department>();
            Department IT = new Department() 
            {
               DeptID=1,DeptName="Information Technology"
            };
            lstDepartment.Add(IT);

            Department Sales = new Department()
            {
                DeptID=2,DeptName="Sales and Logistics"
            };
            lstDepartment.Add(Sales);

            Department HR = new Department()
            {
                DeptID=3,DeptName="Human Resources"
            };
            lstDepartment.Add(HR);

            foreach (Department department in lstDepartment)
            {
                Console.WriteLine($"DeptID::{department.DeptID} DeptName::{department.DeptName} ");
                
            }
            Console.ReadLine();



        }
    }

    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        


    }
}
