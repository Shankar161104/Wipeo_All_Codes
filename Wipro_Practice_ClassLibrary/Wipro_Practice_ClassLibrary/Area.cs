using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_ClassLibrary
{
    public class Area : AbstractArea
    {
        public override int AreaRectangle(int length, int width)
        {
            int result = length * width;
            return result;
        }

        public override int AreaSquare(int side)
        {
            int result = side * side;
            return result;
        }

        public override double AreaCircle(double radius)
        {
            double result = 3.14f * radius * radius;
            return result;
        }
    }
}
