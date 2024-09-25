using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            object obj = num;
            num = 300;
            Console.WriteLine(num);
            Console.WriteLine(obj);
            Console.ReadLine();
        }
    }
}
