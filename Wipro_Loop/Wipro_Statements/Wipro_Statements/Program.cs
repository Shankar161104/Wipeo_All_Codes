using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            if (n % 2 == 0)
            {
                Console.WriteLine("n is an even number");
            }
            else
            {
                Console.WriteLine("n is an odd number");
            }

            Console.ReadLine();
        }
    }
}
