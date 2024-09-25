using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Func_Anonymous
{
    internal class Program
    {
        public delegate int RectangleAreaDelegate(int length, int width);
        public delegate int SquareAreaDelegate(int side);

        static void Main(string[] args)
        {
            
            RectangleAreaDelegate rectangleArea = delegate (int length1, int width1)
            {
                return length1 * width1;
            };


            Func<int, int> squareArea = delegate (int side1)
            {
                return side1 * side1;
            };


            Console.WriteLine("Enter the length of the rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            int width = Convert.ToInt32(Console.ReadLine());

            int rectangleAreaResult = rectangleArea.Invoke(length, width);


            Console.WriteLine("Enter the side length of the square:");
            int side = Convert.ToInt32(Console.ReadLine());

            
           
            int squareAreaResult = squareArea.Invoke(side);

            
            Console.WriteLine($"The area of the rectangle is: {rectangleAreaResult}");
            Console.WriteLine($"The area of the square is: {squareAreaResult}");

            Console.ReadLine();

        }

    }
}
