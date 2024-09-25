using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Practice_17_08_2024
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator.GetCalculator.ValueOne = 100;
            Calculator.GetCalculator.ValueTwo = 26;

            Console.WriteLine("Addition::"+Calculator.GetCalculator.Addition());
            double sub=Calculator.GetCalculator.Subtraction();
            Console.WriteLine($"Subtraction::{sub}");

            Console.ReadLine();
        }
    }
}
