using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_ClassLibrary
{
    public abstract class AbstractArea
    {
        public abstract int AreaRectangle(int length, int width);
        public abstract int AreaSquare(int side);

        public abstract double AreaCircle(double radius);

    }
}
