using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Area objArea = new Area();
            int arearect = objArea.AreaRectangle(2,3);
            int areasquare = objArea.AreaSquare(2);
            double areacircle = objArea.AreaCircle(4);

            Console.WriteLine($"Area of Rectangle::{arearect}  Area Of Square::{areasquare}  Area Of Circle::{areacircle}");
            Console.ReadLine();
        }
    }
}
