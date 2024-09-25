using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ExceptionHandling_eg1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5};
           for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The elements in array::{arr[i]}");
            }

            try
            {
                Console.WriteLine(arr[6]);
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An Exception has Occured::{ex.Message}");
            }
          
            Console.ReadLine();
        }
    }
}
