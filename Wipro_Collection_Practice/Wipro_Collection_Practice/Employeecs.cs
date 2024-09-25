using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_Practice
{
    public class Employeecs
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary { get; set; }
        public string EmpDesignation { get; set; }

        public List<Department> lstDept { get; set; }


    }
}
