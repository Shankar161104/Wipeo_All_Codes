using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Lambda_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations operations = new ArithmeticOperations();

            Console.WriteLine("Addition: " + operations.Add(5, 3));
            Console.WriteLine("Subtraction: " + operations.Subtract(5, 3));
            Console.WriteLine("Multiplication: " + operations.Multiply(5, 3));
            Console.WriteLine("Division: " + operations.Divide(5, 3));


            Console.WriteLine("=========================================================");



            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> subtract = (a, b) => a - b;
            Func<int, int, int> multiply = (a, b) => a * b;
            Func<int, int, double> divide = (a, b) => (double)a / b;

            Console.WriteLine("Addition: " + add(5, 3));
            Console.WriteLine("Subtraction: " + subtract(5, 3));
            Console.WriteLine("Multiplication: " + multiply(5, 3));
            Console.WriteLine("Division: " + divide(5, 3));




        }

       

        

        

    }

    class ArithmeticOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            return (double)a / b;
        }

    }

    }
