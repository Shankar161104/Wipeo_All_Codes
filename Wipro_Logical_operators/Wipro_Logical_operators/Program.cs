using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Logical_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool bool1 = true, bool2 = true;
            bool result;
            result = bool1 && bool2;
            Console.WriteLine($"The result for AND operator is::{result}");
            result = bool1 || bool2;
            Console.WriteLine($"The result for OR operator is::{result}");
            Console.ReadLine();

        }
    }
}
