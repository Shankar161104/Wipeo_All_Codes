using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Out_Parameters_multiplereturns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add, sub, mul, div;
            Console.WriteLine("enter the 1st value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd value");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Program objProgram = new Program();
            objProgram.Arithmetic(num1,num2,out add,out sub,out mul,out div);
            Console.ReadLine();


        }
        public void Arithmetic(int num1,int num2,out int add,out int sub,out int mul,out int div)
        {
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            Console.WriteLine($"Addition::{add}");
            Console.WriteLine($"Subtraction::{sub}");
            Console.WriteLine($"Multiplication::{mul}");
            Console.WriteLine($"Division::{div}");
        }
        
    }
}
