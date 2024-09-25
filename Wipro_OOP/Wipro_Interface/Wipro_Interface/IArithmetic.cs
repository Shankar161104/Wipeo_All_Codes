using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface
{
    public interface IArithmetic
    {
        int Addition(int a,int b);
        int Subtraction(int a,int b);
        int Multiplication(int a, int b);
        int Division(int a,int b );
    }
}
