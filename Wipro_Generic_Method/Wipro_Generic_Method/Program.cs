using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_Method
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.Job<string>("JOBLESS");
            objEmployee.Job<int>(40000);
            objEmployee.Job<bool>(true);

            Console.ReadLine();
        }
    }

    public class Employee
    {
        public void Job<T>(T value)
        {
            Console.WriteLine(value);
        }
    }
}
