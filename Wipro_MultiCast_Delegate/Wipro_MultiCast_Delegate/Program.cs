using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_MultiCast_Delegate
{
    internal class Program
    {
        public delegate void ArithmeticDelegate(int a,int b);
        static void Main(string[] args)
        {
            ArithmeticDelegate objArithmeticDelegate = new ArithmeticDelegate(Addition);
            objArithmeticDelegate += new ArithmeticDelegate(Subtraction);
            objArithmeticDelegate += new ArithmeticDelegate(Multiplication);
            objArithmeticDelegate += new ArithmeticDelegate(Division);

            objArithmeticDelegate.Invoke(10,5);
            Console.ReadLine();

        }
        public static void Addition(int a, int b)
        {
            int result= a + b;
            Console.WriteLine($"Addition::{result}");
        }


        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine($"Subtraction::{result}");
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine($"Multiplication::{result}");
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine($"Division::{result}");
        }
    }
}
