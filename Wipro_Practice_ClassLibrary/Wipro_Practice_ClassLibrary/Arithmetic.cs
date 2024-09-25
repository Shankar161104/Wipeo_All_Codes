using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_ClassLibrary
{
    public class Arithmetic:AbstractArithmetic
    {
        public override int Addition(int num1,int num2)
        {
            return num1 + num2;
        }
        public override int Subtraction(int num1, int num2)
        {
            return num1 - num2;
        }
        public override int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public override int Division(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
