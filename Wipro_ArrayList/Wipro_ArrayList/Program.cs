using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(1);
            arrList.Add("Wipro");
            arrList.Add(2);
            arrList.Add("TCS");
            arrList.Add("");
            arrList.Add("GENPACT");


            foreach(var item in arrList)
            {
                Console.WriteLine(item);
            }

            for(int i = 0; i < arrList.Count; i++)
            {
                Console.WriteLine(arrList[i]);
            }


            


            Console.ReadLine();
        }
    }
}
