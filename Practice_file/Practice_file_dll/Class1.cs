using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_file_dll
{
    public class Class1
    {
        public void Subtraction()
        {
            int a = 20;
            int b = 10;
            int c = a - b;
            Console.WriteLine($"The difference b/w a and b is ::{c}");
        }
        public void Addition()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine($"The sum of a and b is ::{c}");
        }

        public void Factorial()
        {
            int range = 5, fact = 1;
            for(int i = 1; i <= range; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine($"The factorial of {range} is :: {fact} ");
        }
    }
}
