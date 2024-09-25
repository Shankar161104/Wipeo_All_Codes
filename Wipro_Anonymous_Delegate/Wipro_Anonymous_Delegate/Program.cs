using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Anonymous_Delegate
{
    internal class Program
    {
        public delegate int AddDelegate(int a, int b);
        static void Main(string[] args)
        {
            AddDelegate objAddDelegate = delegate(int a,int b)
            {
                return a + b;
            };
            

            Console.WriteLine("Enter the first number:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            int sum = objAddDelegate(firstNumber, secondNumber);
            Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is: {sum}");

            Console.ReadLine();
        }
    }
}
