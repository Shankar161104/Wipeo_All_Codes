using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Function_passingfrom_anotherclass
{
    public class Area
    {
        public int AreaRectangle(int  length,int breadth)
        {
            int result = length * breadth;
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
