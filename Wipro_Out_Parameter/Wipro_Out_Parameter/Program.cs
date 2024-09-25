using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Out_Parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value;
            Program objProgram = new Program();
            objProgram.OutParameter(out value);
            Console.WriteLine($"the value after passing the function is{value}");
            Console.ReadLine();

        }
        public void OutParameter(out int value)
        {
            int res=4;
            value = res;
            value = value * value;
            Console.WriteLine($"The value after passing insinde function is {value}");
           
        }
    }
}
