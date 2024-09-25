using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Areas.dll;

namespace Wipro_Areas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Areas arr = new Areas();
            arr.AreaRect();
            
            arr.AreaSquare();
            arr.AreaCircle();
            arr.AreaTriangle();
            arr.Addition();
            Console.ReadLine();
        }
    }
}
