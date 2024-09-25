using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic ar = new Arithmetic();
            ar.Addition();
            ar.Subtraction();
            ar.Multiplication();
            Console.ReadLine();
        }
        


    }
    public class Arithmetic
    {
        public void Addition()
        {
            int a = 10;
            int b = 20;
            int res = a + b;
            Console.WriteLine(res);
        }

        public void Subtraction()
        {
            int a = 10;
            int b = 20;
            int res = a - b;
            Console.WriteLine(res);
        }

        public void Multiplication()
        {
            int a = 10;
            int b = 20;
            int res = a * b;
            Console.WriteLine(res);
        }
    }
}
