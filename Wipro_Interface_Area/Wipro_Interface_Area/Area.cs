using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Area
{
    public class Area:IArea
    {
       public int AreaRectangle(int length,int width)
        {
            int result = length * width;
            return result;
        }

        public int AreaSquare(int side)
        {
            int result = side * side;
            return result;
        }

        public double AreaCircle(int radius)
        {
            double result = 3.14f * radius * radius;
            return result;
        }

    }
}
