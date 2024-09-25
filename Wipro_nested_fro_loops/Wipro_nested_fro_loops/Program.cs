using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_nested_fro_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;

            
            for (int i = 1; i <= a; i++)
            {
                
                for (int j = 1; j <= b; j++)
                {
                    Console.WriteLine($"{i} {j}");
                }
            }
            Console.WriteLine("************************************");


            for (int i = a; i >= 1; i--)
            {

                for (int j = b; j >= 1; j--)
                {
                    Console.WriteLine($"{i} {j}");
                }
            }


            Console.ReadLine();
        }
    }
}
