using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Statements_Userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} is even");
            }
            else
            {
                Console.WriteLine($"{n} is odd");
            }
            Console.ReadLine();
        }
    }
}
