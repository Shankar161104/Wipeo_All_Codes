using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Else_if_ladder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n<0 || n>100)
            {
                Console.WriteLine("Invalid");
            }
            else if(n>=0 && n < 40)
            {
                Console.WriteLine("Fail");
            }
            else if (n >= 40 && n < 50)
            {
                Console.WriteLine("c grade");
            }
            else if (n >= 50 && n < 65)
            {
                Console.WriteLine("b grade");
            }
            else if (n >= 65 && n < 75)
            {
                Console.WriteLine("a grade");
            }
            else if (n >= 75 && n < 95)
            {
                Console.WriteLine("a++ grade");
            }
            else if (n >= 95 && n<=100)
            {
                Console.WriteLine("Outstanding");
            }
            Console.ReadLine();
            goto start;
        }
    }
}
