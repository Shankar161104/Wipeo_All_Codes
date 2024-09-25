using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_enum
{
    internal class Program
    {
        public enum Days {Monday=1,Tuesday=2,Wednesday=3,Thursday=4,friday=5,Saturday=6,Sunday=7 }
        static void Main(string[] args)
        {
            int mon = (int)Days.Monday;
            int tue = (int)Days.Tuesday;
            int wed = (int)Days.Wednesday;
            int thu = (int)Days.Thursday;
            int fri = (int)Days.friday;
            int sat = (int)Days.Saturday;
            int sun = (int)Days.Sunday;

            Console.WriteLine($"The index of mon is::{mon}");
            Console.WriteLine($"The index of tue is::{tue}");
            Console.WriteLine($"The index of wed is::{wed}");
            Console.WriteLine($"The index of thu is::{thu}");
            Console.WriteLine($"The index of fri is::{fri}");
            Console.WriteLine($"The index of sat is::{sat}");
            Console.WriteLine($"The index of sun is::{sun}");
           

            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }

            int value = (int)Days.Monday;
            string str = Enum.GetName(typeof(Days),value);
            Console.WriteLine($"Index::{value}  Day::{str}");

             value = (int)Days.Tuesday;
             str = Enum.GetName(typeof(Days), value);
            Console.WriteLine($"Index::{value}  Day::{str}");

             value = (int)Days.Wednesday;
             str = Enum.GetName(typeof(Days), value);
            Console.WriteLine($"Index::{value}  Day::{str}");

             value = (int)Days.Thursday;
             str = Enum.GetName(typeof(Days), value);
            Console.WriteLine($"Index::{value}  Day::{str}");

             value = (int)Days.friday;
             str = Enum.GetName(typeof(Days), value);
            Console.WriteLine($"Index::{value}  Day::{str}");
            Console.ReadLine();



        }
    }
}
