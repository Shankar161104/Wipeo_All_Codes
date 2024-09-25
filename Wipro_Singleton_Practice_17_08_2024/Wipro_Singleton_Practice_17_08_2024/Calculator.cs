using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Practice_17_08_2024
{
    public sealed class Calculator
    {
        public double ValueOne { get; set; }
        public double ValueTwo { get; set; }

        public double Addition()
        {
            return ValueOne + ValueTwo;
        }

        public double Subtraction()
        {
            return ValueOne - ValueTwo;
        }


        public double Multiplication()
        {
            return ValueOne * ValueTwo;
        }
        private Calculator()
        {

        }
        private static Calculator Instance=null;
        public static Calculator GetCalculator
        {
            get
            {
                if (Instance==null)
                {
                    Instance = new Calculator();
                }
                return Instance;
            }
        }
        
    }
}
