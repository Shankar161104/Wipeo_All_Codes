using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Practice_ClassLibrary;

namespace Wipro_Practice_Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====AREA PROGRAM=======");
            Area objArea = new Area();
            Console.WriteLine("Enter the Length value::");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the width value");
            int width = Convert.ToInt32(Console.ReadLine());

            int rectarea = objArea.AreaRectangle(length, width);
            Console.WriteLine($"The area of rectangle is ::{rectarea}");

            Console.WriteLine("Enter the side value");
            int side = Convert.ToInt32(Console.ReadLine());
            int squarearea = objArea.AreaSquare(side);
            Console.WriteLine($"The Area of Square is::{squarearea}");


            Console.WriteLine("Enter the Radius value");
            int radius = Convert.ToInt32(Console.ReadLine());
            int circlearea = objArea.AreaSquare(radius);
            Console.WriteLine($"The Area of Circle is::{circlearea}");
            Console.WriteLine("=====ARITHMETIC PROGRAM=======");
            Arithmetic objArithmetic = new Arithmetic();
            Console.WriteLine("Enter the num1 value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2 value");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = objArithmetic.Addition(num1,num2);
            int sub = objArithmetic.Subtraction(num1,num2);
            int mul = objArithmetic.Multiplication(num1,num2);
            int div = objArithmetic.Division(num1,num2);

            Console.WriteLine($"Addition is::{sum}");
            Console.WriteLine($"Subtraction is::{sub}");
            Console.WriteLine($"Multiplication is::{mul}");
            Console.WriteLine($"Division is::{div}");

            



            Console.ReadLine();
        }
    }
}
