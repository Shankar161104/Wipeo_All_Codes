using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_Arithmetic
{
    public interface IArithmetic<T>
    {
        T Add(T a,T b);
    }

}
