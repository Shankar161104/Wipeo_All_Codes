using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Arithmetic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            int result = a + b;
            Console.WriteLine($"The sum of a and b is :: {result}");
            result = a - b;
            Console.WriteLine(result);
            result = a * b;
            Console.WriteLine(result);
            result = a / b;
            Console.WriteLine(result);
            result = a % b;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
