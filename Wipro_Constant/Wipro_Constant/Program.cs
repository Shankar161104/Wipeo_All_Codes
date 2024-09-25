using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Constant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constants objconstant = new Constants();

            Console.WriteLine($"{Constants.num1}");
        }
    }

    public class Constants
    {
        public const int num1 = 1;
    }
}
