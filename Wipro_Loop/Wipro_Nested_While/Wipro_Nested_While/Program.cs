using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Nested_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 3)
            {
                int j = 1;
                while (j <= 2) 
                {
                    Console.Write(i + " "); 
                    j++;
                }
                Console.WriteLine(); 
                i++;
            }


            Console.ReadLine();
        }
    }
}

