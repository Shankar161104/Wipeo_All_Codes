using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Action_Anonymous
{
    internal class Program
    {
        public delegate int RectangleAreaDelegate(int length, int width);
        public delegate void SquareAreaDelegate(int side);
        static void Main(string[] args)
        {
            Action<int, int> rectangleArea =delegate (int length1, int width1)
            {
                int area = length1 * width1;
                Console.WriteLine($"The area of the rectangle is: {area}");
            };

            Action<int> squareArea = delegate (int side1)
            {
                int area = side1 * side1;
                Console.WriteLine($"The area of the square is: {area}");
            };

           
            Console.WriteLine("Enter the length of the rectangle:");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of the rectangle:");
            int width = Convert.ToInt32(Console.ReadLine());


            rectangleArea.Invoke(length, width);

            Console.WriteLine("Enter the side length of the square:");
            int side = Convert.ToInt32(Console.ReadLine());

          
           
            squareArea.Invoke(side);

            Console.ReadLine();
        }
    }
}
