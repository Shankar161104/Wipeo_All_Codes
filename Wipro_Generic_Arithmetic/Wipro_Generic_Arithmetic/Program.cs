using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArithmetcOperation<int> objArithmeticint = new ArithmetcOperation<int>();
            int isum = objArithmeticint.Add(10, 22);
            Console.WriteLine($"The Addition of int numbers::{isum}");


            ArithmetcOperation<float> objArithmeticfloat = new ArithmetcOperation<float>();
            float fsum = objArithmeticfloat.Add(10.2f,22.3f);
            Console.WriteLine($"The Addition of float numbers::{fsum}");

            ArithmetcOperation<double> objArithmeticdouble = new ArithmetcOperation<double>();
            double dsum = objArithmeticdouble.Add(15.2d, 32.3d);
            Console.WriteLine($"The Addition of double numbers::{dsum}");

            Console.ReadLine();
        }
    }
}
