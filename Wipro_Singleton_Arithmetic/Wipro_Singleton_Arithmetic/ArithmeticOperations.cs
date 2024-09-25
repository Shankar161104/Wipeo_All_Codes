using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wipro_Singleton_Arithmetic
{
    public sealed class ArithmeticOperations
    {

        private static ArithmeticOperations instance;
        private ArithmeticOperations() 
        {

        }
        public static ArithmeticOperations GetArithmetic()
        {
            if (instance == null)
            {
                instance = new ArithmeticOperations();
            }
            return instance;
        }

        
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


    }
}
