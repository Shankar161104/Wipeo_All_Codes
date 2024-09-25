using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Delegate
{
    internal class Program
    {
        public delegate int ArithmeticDelegate(int a, int b);
        static void Main(string[] args)
        {
            ArithmeticDelegate objArithmeticdelegate = new ArithmeticDelegate(Addition);
            int sum = objArithmeticdelegate.Invoke(10,20);
            Console.WriteLine($"THe Sum is::{sum}");
            Console.ReadLine();
        }

        public static int Addition(int a,int b)
        {
            return a + b;
        }
    }
}
