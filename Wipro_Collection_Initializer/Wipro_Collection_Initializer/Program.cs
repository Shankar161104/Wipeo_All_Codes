using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Collection_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrCollectionInitializerArrayList = new ArrayList()
            {
                7,8,9,"Shankar","Lakshmi","Jaya","Rao",3.14f
            };
            foreach(var item in arrCollectionInitializerArrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
