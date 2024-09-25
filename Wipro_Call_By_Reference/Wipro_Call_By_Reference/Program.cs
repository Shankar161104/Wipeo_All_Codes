using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Call_By_Reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 50;
            Console.WriteLine($"The value passed before passing the function::{value} ");
            Program objProgram = new Program();
            objProgram.Call_By_Reference( ref value);
            Console.WriteLine($"The value passed after passing the function::{value} ");
            Console.ReadLine();

        }
        public void Call_By_Reference(ref int value)
        {
            value *= value;
            Console.WriteLine($"The value inside the function is {value}");
        }
    }
}
