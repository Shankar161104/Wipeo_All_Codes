using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singeton_Lock_Employee
{
    public sealed class Employee
    {
        private Employee()
        {

        }
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public float EmpSalary { get; set; }

        private static readonly Employee padlock=new Employee();
        private static Employee instance = null;
        public static Employee Instance
        {
            get
            {
                lock (padlock)
                {
                    if(instance == null)
                    {
                        instance = new Employee();
                    }
                    return instance;
                }
            }
        }
       
    }
}
