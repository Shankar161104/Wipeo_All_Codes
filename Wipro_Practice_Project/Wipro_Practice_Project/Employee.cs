using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Project
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAddress { get; set; }
        public float EmployeeContact { get; set; }
        public string EmployeeEmail { get; set; }
        public List<Department> Lstdept { get; set; }
    }
}
