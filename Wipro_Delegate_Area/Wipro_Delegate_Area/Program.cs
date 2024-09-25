using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Delegate_Area
{
    internal class Program
    {
        public delegate int AreaRectDelegate(int length,int width);
        public delegate int AreaSquareDelegate(int side);
        public delegate float AreaCircleDelegate(int radius);

        static void Main(string[] args)
        {
            Area objArea = new Area();
            AreaRectDelegate objAreaRectDelegate = new AreaRectDelegate(objArea.AreaRectangle);
            Console.WriteLine("Enter the length value");
            int length= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width value");
            int width = Convert.ToInt32(Console.ReadLine());
            int arearect = objAreaRectDelegate.Invoke(length, width);
            Console.WriteLine($"Area of Rectangle is::{arearect}");

            AreaSquareDelegate objAreaSquareDelegate = new AreaSquareDelegate(objArea.AreaSquare);
            Console.WriteLine("Enter the side value");
            int side = Convert.ToInt32(Console.ReadLine());
            int areasquare = objAreaSquareDelegate.Invoke(side);
            Console.WriteLine($"Area of Rectangle is::{areasquare}");

            AreaCircleDelegate objAreaCircleDelegate = new AreaCircleDelegate(objArea.AreaCircle);
            Console.WriteLine("Enter the radius value");
            int radius = Convert.ToInt32(Console.ReadLine());
            int areacircle = objAreaSquareDelegate.Invoke(radius);
            Console.WriteLine($"Area of Rectangle is::{areacircle}");

            Console.ReadLine();







        }
    }
    public class Area
    {
        public int AreaRectangle(int length, int width)
        {
            int result = length * width;
            return result;
        }


        public int AreaSquare(int side)
        {
            int result = side * side;
            return result;
        }
        public float AreaCircle(int radius)
        {
            float result = 3.14f * radius * radius;
            return result;
        }


    }
}
