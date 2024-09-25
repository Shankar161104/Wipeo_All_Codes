using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("enter the n value");
            int n = Convert.ToInt32(Console.ReadLine());
            
            switch (n)

            {
                  
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                case 4:
                    Console.WriteLine("case 4");
                    break;
                case 5:
                    Console.WriteLine("case 5");
                    break;
                case 6:
                    Console.WriteLine("case 6");
                    break;
                default:
                    Console.WriteLine("Not in the given cases");
                    break;

                    


            }
            goto start;

            Console.ReadLine();
        }
    }
}
