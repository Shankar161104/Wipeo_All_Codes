using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Wipro_Abstract_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {

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





            Console.ReadLine();


        }
    }

    public abstract class  AbstractArea{
        public abstract int AreaRectangle(int length, int width);
        public abstract int AreaSquare(int side);

        public abstract double AreaCircle(double radius);

   }

    public class Area : AbstractArea
    {
        public override int AreaRectangle(int length, int width)
        {
          int  result = length * width;
           return result;
        }

        public override int AreaSquare(int side)
        {
            int result = side*side;
            return result;
        }

        public override double AreaCircle(double radius)
        {
            double result = 3.14f * radius * radius;
            return result;
        }
    }
}
