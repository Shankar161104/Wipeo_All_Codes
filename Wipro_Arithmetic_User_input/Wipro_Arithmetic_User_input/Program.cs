using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Arithmetic_User_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b value");
            int b = Convert.ToInt32(Console.ReadLine());
            int result = a - b;
            Console.WriteLine($"The difference is ::{ result}");
            result = a * b;
            Console.WriteLine($"The product is ::{ result}");
            result = a / b;
            Console.WriteLine($"The division is ::{ result}");
            result = a % b;
            Console.WriteLine($"The modulus is ::{ result}");
            result = a + b;
            Console.WriteLine($"The sum is ::{ result}");
            Console.ReadLine();
            goto start;

        }
    }
}
