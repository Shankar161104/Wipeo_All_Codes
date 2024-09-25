using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Function_passingfrom_anotherclass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Area objArea = new Area();
            Console.WriteLine("enter the length value");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the width value");
            int width = Convert.ToInt32(Console.ReadLine());
            
            int rectarea=objArea.AreaRectangle(length,width);
            Console.WriteLine($"The area of rectangle is ::{rectarea}");
           
            Console.WriteLine("enter the side value");
            int side = Convert.ToInt32(Console.ReadLine());
            int squarearea = objArea.AreaSquare(side);
            Console.WriteLine($"The area od square is ::{squarearea}");

            Console.WriteLine("enter the radius value");
            int radius = Convert.ToInt32(Console.ReadLine());
            double circlearea = objArea.AreaCircle(radius);
            Console.WriteLine($"The area of circle is ::{circlearea}");





            Console.ReadLine();

        }
    }
}
