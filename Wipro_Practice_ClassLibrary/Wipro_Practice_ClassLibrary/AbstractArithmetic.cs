using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_ClassLibrary
{
    public abstract class AbstractArithmetic
    {
        public abstract int Addition(int num1,int num2);
        public abstract int Subtraction(int num1, int num2);
        public abstract int Multiplication(int num1, int num2);
        public abstract int Division(int num1, int num2);
    }
}
