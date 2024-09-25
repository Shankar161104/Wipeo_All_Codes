using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Area_MultiCast_delegate
{
    internal class Program
    {
        public delegate int  AreaRectDelegate(int length,int width);
        public delegate int AreaSquareDelegate(int side);
        public delegate float AreaCircleDelegate(int radius);
        static void Main(string[] args)
        {
            Area objArea = new Area();
            AreaRectDelegate objRectDelegate = new AreaRectDelegate(objArea.AreaRectangle);
            
            
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
