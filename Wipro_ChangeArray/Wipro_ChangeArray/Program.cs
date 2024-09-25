using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ChangeArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            arr[0]= 55;
            Console.WriteLine($"1st element {arr[0]}");
            arr[1] = 77;
            Console.WriteLine($"2nd element {arr[1]}");
            Console.WriteLine($"3rd element {arr[2]}");


            Console.ReadLine();
        }
    }
}
