using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_eg_3
{
    internal class AreaOperations<T>:IArea<T>
    {
        public T AreaRectangle(T length, T width)
        {
            dynamic l = length;
            dynamic w = width;
            return l * w;
        }
    }
}
