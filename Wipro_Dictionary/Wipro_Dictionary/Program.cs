using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1,"Shankar");
            myDictionary.Add(2,"Jai");
            myDictionary.Add(3, "Swathi");
            myDictionary.Add(4, "Jai");

            foreach (KeyValuePair<int,string> kvp in myDictionary)
            {
                Console.WriteLine($"Keys::{kvp.Key}  Value::{kvp.Value}");
            }
            Console.ReadLine();
        }
    }
}
