using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Func_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> objFuncAdd = Addition;
            int sum = objFuncAdd.Invoke(2,4);
            Console.WriteLine($"Addition::{sum}");

            Func<int, int, int> objFuncSub = Subtraction;
            int sub = objFuncSub.Invoke(4,2);
            Console.WriteLine($"Subtraction::{sub}");

            Console.ReadLine();
        }

        public static int Addition(int a,int b)
        {
            int result = a + b;
            return result;
        }

        public static int Subtraction(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
