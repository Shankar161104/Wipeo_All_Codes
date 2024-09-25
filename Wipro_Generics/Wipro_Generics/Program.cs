using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<int> objEmpID = new Employee<int>();
            objEmpID.Value = 1;

            Employee<string> objEmpName = new Employee<string>();
            objEmpName.Value = "Shankar";

            Employee<float> objEmpSalary = new Employee<float>();
            objEmpSalary.Value = 120000;

            Employee<string> objEmpAddress = new Employee<string>();
            objEmpAddress.Value = "INDIA";

            
        }
    }
    public class Employee<T>
    {
        public T Value { get; set; }
    }
}
