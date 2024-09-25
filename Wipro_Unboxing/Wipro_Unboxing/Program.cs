using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 30;
            object obj = num;
            int i = (int)obj;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}
