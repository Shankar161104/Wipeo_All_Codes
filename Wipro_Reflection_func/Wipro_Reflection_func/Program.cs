using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Reflection_func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> hasLength = str => str.Length > 3;
            string[] Countries = {"Monglia","India","UK","USA","China","Switzerland","Bali" };
            IEnumerable<string> country = Countries.Where(hasLength);
            foreach (var item in country)
            {
                Console.WriteLine($"Countries::{item}");
            }
            Console.ReadLine();
        }
    }
}
