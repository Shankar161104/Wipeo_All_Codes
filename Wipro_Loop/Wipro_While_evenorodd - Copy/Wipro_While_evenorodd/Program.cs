using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_While_evenorodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n <= 50)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine($"{n} is even");
                }
                else
                {
                    Console.WriteLine($"{n} is odd");
                }
                n++;
               
            }
            Console.ReadLine();
        }
    }
}
