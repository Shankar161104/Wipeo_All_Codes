using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Increment_and_Decrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int res = a++;
            Console.WriteLine(a);
            Console.WriteLine(res);

             res = ++a;
            Console.WriteLine(a);
            Console.WriteLine(res);

            res = a--;
            Console.WriteLine(a);
            Console.WriteLine(res);

            res = --a;
            Console.WriteLine(a);
            Console.WriteLine(res);

            Console.ReadLine();

        }
    }
}
