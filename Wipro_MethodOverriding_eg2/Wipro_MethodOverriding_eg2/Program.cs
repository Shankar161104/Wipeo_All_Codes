using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_MethodOverriding_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle objRectangle = new Rectangle(10,20);
           int rectarea= objRectangle.Area();
            Console.WriteLine($"{rectarea}");
            Console.ReadLine();

        }
    }

    public abstract class Shape
    {
        public abstract int Area();
    }

    public class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int _length=10, int _width=20)
        {
            length = _length;
            width = _width;
        }

        public override int Area()
        {
            Console.WriteLine("The Area of Rectangle is::");
            return length * width;
        }
    }
}
