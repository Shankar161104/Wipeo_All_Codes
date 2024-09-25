using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Constructor_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area area1 = new Area();
            int rectarea=  area1.AreaRectangle(1,2);
            int squarearea=area1.AreaSquare(4);
            Console.WriteLine($"Area of Rectangle::{rectarea}  Area Of Square::{squarearea}");


            Area area2 = new Area();
             rectarea = area1.AreaRectangle(1, 2);
             squarearea = area1.AreaSquare(4);
            Console.WriteLine($"Area of Rectangle::{rectarea}  Area Of Square::{squarearea}");
            Console.ReadLine();

        }
    }
    public class Area
    {
        public Area()
        {
            Console.WriteLine("Area Constructor invoked");
        }
        public int AreaRectangle(int length,int breadth)
        {
            int result = length * breadth;
            return result;
        }
        public int AreaSquare (int side)
        {
            int result = side * side;
            return result;
        }
    }
}
