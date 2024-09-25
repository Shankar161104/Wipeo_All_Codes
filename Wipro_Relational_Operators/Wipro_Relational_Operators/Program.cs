using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Arithmetic_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 10.6f;
            float b = 6.22f;
            float result = a + b;
            Console.WriteLine($"Sum of a and b is ::{result}");
            result = a - b;
            Console.WriteLine($"Differenc eb/w a and b is :: {result}");
            result = a / b;
            Console.WriteLine($"the value of a divides b is:: {result}");
            result = a * b;
            Console.WriteLine($"product of a and b is :: {result}");
            Console.ReadLine();
        }
    }
}
