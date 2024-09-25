using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Switcheg_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            char ch;
            double one, two, res;
            Console.WriteLine("enter the 1st number");
            one = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("enter the 2nd number");
            two = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the operator");
            ch = (char)Console.Read();

            switch (ch)
            {
                case '+':
                    res = one + two;
                    Console.WriteLine($"{res}");
                    break;

                case '-':
                    res = one - two;
                    Console.WriteLine($"{res}");
                    break;

                case '*':
                    res = one * two;
                    Console.WriteLine($"{res}");
                    break;

                case '/':
                    res = one / two;
                    Console.WriteLine($"{res}");
                    break;

                case '%':
                    res = one % two;
                    Console.WriteLine($"{res}");
                    break;

                default:
                    Console.WriteLine("invalid");
                    break;
            }
            goto start;
        }
    }
}
