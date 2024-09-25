using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Method_Overloading_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = new Arithmetic();
            int Integer=objArithmetic.Add(1,2);
            decimal Decimal=objArithmetic.Add(1.2m,2.3m);
            float Float=objArithmetic.Add(1.2f,2.3f);

            Console.WriteLine($"Integer::{Integer}  Decimal::{Decimal}  Float::{Float}");
            Console.ReadLine();
            ;        }
    }


    public class Arithmetic
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public float Add(float a,float b)
        {
            return a + b;
        }
        public decimal Add(decimal a,decimal b)
        {
            return a + b;
        }
    }
}
