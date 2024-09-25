using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lstNames = new HashSet<string>();
            lstNames.Add("Om");
            lstNames.Add("namo");
            lstNames.Add("Bhagavate");
            lstNames.Add("Rudraya");
            lstNames.Add("Om");
            lstNames.Add("Om");

            foreach (var item in lstNames)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
