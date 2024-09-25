using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Delegate_Operations
{
    internal class Program
    {
        public delegate int AdditionDelegate(int a, int b);
        public delegate int SubtractionDelegate(int a, int b);
        public delegate int MultiplicationDelegate(int a,int b);
        public delegate int DivisionDelegate(int a, int b);
        static void Main(string[] args)
        {
            AdditionDelegate objAddDelegate = new AdditionDelegate(Addition);
            Console.WriteLine("Enter the a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the a value");
            int b = Convert.ToInt32(Console.ReadLine());
            int sum = objAddDelegate.Invoke(a,b);
            Console.WriteLine($"Addition is::{sum}");

            SubtractionDelegate objSubDelegate = new SubtractionDelegate(Subtraction);
            Console.WriteLine("Enter the a value");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the a value");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int sub = objSubDelegate.Invoke(a1, b1);
            Console.WriteLine($"Addition is::{sub}");
            Console.ReadLine();

            MultiplicationDelegate objMulDelegate = new MultiplicationDelegate(Multiplication);
            Console.WriteLine("Enter the a value");
            int a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the a value");
            int b2 = Convert.ToInt32(Console.ReadLine());
            int mul = objSubDelegate.Invoke(a2, b2);
            Console.WriteLine($"Addition is::{mul}");
            Console.ReadLine();

        }

        public static int Addition(int a,int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
