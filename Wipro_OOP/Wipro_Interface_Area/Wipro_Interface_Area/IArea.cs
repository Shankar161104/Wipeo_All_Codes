using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Area
{
    public interface IArea
    {
        int AreaRectangle(int length,int width);
        int AreaSquare(int side);
        double AreaCircle(int radius);
    }
}
