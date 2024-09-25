using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Call_by_value
{
    public class Program
    {
        static void Main(string[] args)
        {
            int value = 50;
            Console.WriteLine($"The value passed before passing to the function is::{value}");

            Program objProgram = new Program();
            objProgram.Call(value);
            Console.WriteLine($"the value passed after passing to the function is::{value}");
            Console.ReadLine();
        }

        public void Call(int value)
        {
            value *= value;
            Console.WriteLine($"The value passed inside this function is::{value}");
        }
    }

   
}
