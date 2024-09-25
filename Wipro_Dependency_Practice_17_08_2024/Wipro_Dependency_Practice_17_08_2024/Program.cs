using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Dependency_Practice_17_08_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee(new Department(1,"shankar"),101,"Jai",3453554,"Hyderabad");
            objEmployee.DisplayEmployeeDetails();

        }
    }
}
