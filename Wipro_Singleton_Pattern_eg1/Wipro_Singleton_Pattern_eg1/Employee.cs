using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Pattern_eg1
{
     class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary { get; set; }

        private static Employee employee;

        private Employee()
        {

        }

        public static Employee CreateObject()
        {
            if (employee == null)
            {
                employee = new Employee();
            }
            return employee;
        }


    }
}
