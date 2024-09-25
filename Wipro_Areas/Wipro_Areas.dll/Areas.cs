using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Wipro_Areas.dll
{
    public class Areas


    {
        public void Addition()
        {
            int a = 10;
            int b = 20;
            int sum = a + b;
            Console.WriteLine(sum);
        }

        public void AreaRect()
        {
            int length = 100;
            int width = 20;
            int area1 = length * width;
            Console.WriteLine($"The area of rectangle is ::{area1}");
            
        }
        public void AreaSquare()
        {
            int side = 10;
            int area2 = side * side;
            Console.WriteLine($"The area of square is ::{area2}");
            
        }
        public void AreaCircle()
        {
            float pi = 3.14f;
            int radius = 10;
            double area3 = pi * radius * radius;
            Console.WriteLine($"The area of circle is :: {area3}");
           
        }

        public void AreaTriangle()
        {
            int length = 10;
            int width = 20;
            double area4 = 0.5 * length * width;
            Console.WriteLine($"The area of Triangle is :: {area4}");
           
        }
        public void Subtraction(int p,int q)
        {

        }
        

    }
}
