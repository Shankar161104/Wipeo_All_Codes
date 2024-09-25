using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Relational_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the b value");
            int b = Convert.ToInt32(Console.ReadLine());
            bool result = a > b;
            Console.WriteLine($"a>b-->{result}");
            result = a < b;
            Console.WriteLine($"a<b-->{result}");
            result = a >= b;
            Console.WriteLine($"a>=b-->{result}");
            result = a <= b;
            Console.WriteLine($"a<=b-->{result}");

            Console.ReadLine();
        }
    }
}
