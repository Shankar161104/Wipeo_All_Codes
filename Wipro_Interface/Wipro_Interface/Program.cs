using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arithmetic objArithmetic = new Arithmetic();
            int addition = objArithmetic.Addition(1,2);
            int subtraction = objArithmetic.Addition(1, 2);

            int multiplication = objArithmetic.Addition(1, 2);

            int division = objArithmetic.Addition(1, 2);

            Console.WriteLine($"Addition::{addition}  Subtraction::{subtraction}  Multiplication::{multiplication}  Division::{division}");
            Console.ReadLine();


        }
    }
}
