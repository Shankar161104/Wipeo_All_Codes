﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface
{
    public class Arithmetic : IArithmetic
    {
        public int Addition(int a,int b)
        {
            return a + b;

        }
        public int Subtraction(int a, int b)
        {
            return a - b;

        }
        public int Multiplication(int a, int b)
        {
            return a * b;

        }

        public int Division(int a, int b)
        {
            return a / b;

        }


    }
    
        


    
}
