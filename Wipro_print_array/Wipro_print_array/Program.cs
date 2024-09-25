using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_print_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'H','E','L','L','O'};
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
