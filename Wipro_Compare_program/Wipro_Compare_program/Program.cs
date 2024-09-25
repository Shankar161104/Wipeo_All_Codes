using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Compare_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 10){
                Console.WriteLine($"{n} is less than 10 ");
            }
            else
            {
                Console.WriteLine($"{n} is greater than 10");
            }
            Console.ReadLine();
        }
    }
}
