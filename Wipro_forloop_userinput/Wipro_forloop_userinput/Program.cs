using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_forloop_userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the testing condition");
            int test = Convert.ToInt32(Console.ReadLine());

            for (int i = n; i <= test; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} is even");
                }
                else
                {
                    Console.WriteLine($"{i} is odd");
                }

            }
            Console.ReadLine();

        }
    }
}
