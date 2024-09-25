using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Area_Anonymous_Delegate
{
    internal class Program
    {
        public delegate int AreaRectDelegate(int length, int width);
        public delegate int AreaSquareDelegate(int side);
        public delegate float AreaCircleDelegate(int radius);
        static void Main(string[] args)
        {
            AreaRectDelegate objAreaRectangle = delegate (int length,int width)
            {
                int result = length * width;
                return result;
            };

            AreaSquareDelegate objAreaSquare = delegate (int side)
            {
                int result = side * side;
                return result;
            };

            AreaCircleDelegate objAreaCircle = delegate (int radius)
            {
                float result = 3.14f*radius*radius;
                return result;
            };

            Console.WriteLine("Enter the length value:");
            int length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width:");
            int width1 = Convert.ToInt32(Console.ReadLine());
            int arearect = objAreaRectangle(length1,width1);
            Console.WriteLine($"Area Of Rectangle: {arearect}");

            
            
            
            Console.WriteLine("Enter the side value:");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int areasquare = objAreaSquare(side1);
            Console.WriteLine($"Area Of Square: {areasquare}");


            Console.ReadLine();

        }
    }
}
