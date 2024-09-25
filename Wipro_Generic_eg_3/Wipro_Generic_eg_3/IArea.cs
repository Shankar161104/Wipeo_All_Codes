using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_eg_3
{
    internal interface IArea<T>
    {
        T AreaRectangle(T length,T width);
        T AreaSquare(T side);
    }
}
