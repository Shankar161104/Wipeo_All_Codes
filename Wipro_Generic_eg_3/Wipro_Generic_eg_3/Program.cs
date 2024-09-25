using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_eg_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaOperations<int> objArea = new AreaOperations<int>();
            int arearect = objArea.AreaRectangle(1, 2);
            Console.WriteLine($"");
        }
    }
}
