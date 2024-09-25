using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listNames = new List<string>();
            listNames.Add("Shankar");
            listNames.Add("Jai");
            listNames.Add("Lakshmi");
            listNames.Add("Wipro");

            foreach (string name in listNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
