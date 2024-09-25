using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Arithmetic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithmeticOperations objArithmetic = ArithmeticOperations.GetArithmetic();


           
            int sum = objArithmetic.Add(10, 5);
            Console.WriteLine($"Addition Result: {sum}");

           
            int difference = objArithmetic.Subtract(10, 5);
            Console.WriteLine($"Subtraction Result: {difference}");



            Console.ReadLine();
        }
    }
}
