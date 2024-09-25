using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Arithmetic_Float_parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("enter the a value");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("enter the b value");
            float b = float.Parse(Console.ReadLine());
           
            float result = a + b;
            Console.WriteLine($"The sum is ::{result}");
           
            result = a - b;
            Console.WriteLine($"The difference is ::{result}");
           
            result = a * b;
            Console.WriteLine($"The product is ::{result}");
           
            result = a / b;
            Console.WriteLine($"The division is ::{result}");
            
            result = a % b;
            Console.WriteLine($"The modulus is ::{result}");
            Console.ReadLine();

            goto start;
        }
    }
}
