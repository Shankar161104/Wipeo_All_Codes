using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Wipro_Arrayeg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,40,50,55 };
            Console.WriteLine("Sum of all elements :"+arr.Sum());
            Console.WriteLine("average of elements:"+arr.Average());
            Console.WriteLine("minimum value in array:"+arr.Min());
            Console.WriteLine("maximum value in array:" + arr.Max());
            Console.ReadLine();
        }
    }
}
