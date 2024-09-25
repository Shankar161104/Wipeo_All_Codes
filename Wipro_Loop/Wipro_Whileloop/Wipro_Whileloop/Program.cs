using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Whileloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i<=10)
            {
                Console.WriteLine(i);
                i++;

            }
            int i1 = 0;
            while (i1 < 10)
            {
                Console.WriteLine(i1);
                i1++;
            }
            int i2 = 10;
            while (i2 >= 0)
            {
                Console.WriteLine(i2);
                i2--;
            }
            Console.ReadLine();
        }
    }
}
