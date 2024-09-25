using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Arithmetic objArithmetic = new Arithmetic();
            int addition=objArithmetic.Addition(2, 4);
            int subtraction = objArithmetic.Subtraction(2, 4);
            int multiplication = objArithmetic.Multiplication(2, 4);
            int division = objArithmetic.Multiplication(2, 4);

            Console.WriteLine($"Addition::{addition}  Subtraction::{subtraction}  Multiplication::{multiplication}  Division::{division}" +
                $" ");

            Console.ReadLine();


        }
    }
    

    public abstract class ArithmeticAbstract
    {
        public abstract int  Addition(int a, int b);
        public abstract int Subtraction(int a, int b);

        public int Multiplication(int a,int b)
        {
            return a * b;
        }

    }

    public class Arithmetic : ArithmeticAbstract
    {
        public override int Addition(int a, int b)
        {
            return a + b;
        }

        public override int Subtraction(int a, int b)
        {
            return a - b;
        }
    }
     
    

       



}

