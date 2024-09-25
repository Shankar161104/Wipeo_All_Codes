using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Programming_languages
{
    internal class Program
    {
        public enum Programming {dotnet=1,AWS=2,C,MVC=4,Angular=5,DotnetCore=6,Azure=7 }
        static void Main(string[] args)
        {

           
            int num = (int)Programming.dotnet;
            string str = Enum.GetName(typeof(Programming), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Programming.AWS;
             str = Enum.GetName(typeof(Programming), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Programming.C;
             str = Enum.GetName(typeof(Programming), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Programming.MVC;
             str = Enum.GetName(typeof(Programming), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Programming.Angular;
             str = Enum.GetName(typeof(Programming), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Programming.DotnetCore;
             str = Enum.GetName(typeof(Programming), num);
            Console.WriteLine($"{str}---> {num}");

            foreach (string s in Enum.GetNames(typeof(Programming)))
            {
                Console.WriteLine($" Name:: {s}");
            }

            Console.ReadLine();



        }
    }
}
