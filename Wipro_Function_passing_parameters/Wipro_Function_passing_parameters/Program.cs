using System;

namespace Wipro_Function_passing_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the n1 value:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the n2 value:");
            int n2 = Convert.ToInt32(Console.ReadLine());

           
            Arithmetic ar = new Arithmetic();
            
            int result = ar.Addition(n1, n2);
            Console.WriteLine("The result of addition is: " + result);

            result = ar.Subtraction(n1, n2);
            Console.WriteLine("The result of subtraction is: "+result);


            result = ar.Multiplication(n1, n2);
            Console.WriteLine("The result of Multiplication is: " + result);

            Console.ReadLine();
        }

        public class Arithmetic
        {
            public int Addition(int n1, int n2)
            {
                return n1 + n2;
            }

            public int Subtraction(int n1, int n2)
            {
                return n1 - n2;
            }

            public int Multiplication(int n1, int n2)
            {
                return n1 * n2;
            }
        }




    }
}
