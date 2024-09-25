using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        public enum Status {Active=1,Inactive=2,Open=3,Closed=4,Hold=5 }
        static void Main(string[] args)
        {
            int act = (int)Status.Active;
            int inact = (int)Status.Inactive;
            int open = (int)Status.Open;
            int close = (int)Status.Closed;
            int hold = (int)Status.Hold;

            Console.WriteLine($"{act}");
            Console.WriteLine($"{inact}");
            Console.WriteLine($"{open}");
            Console.WriteLine($"{close}");
            Console.WriteLine($"{hold}");

            foreach(string s in Enum.GetNames(typeof(Status)))
            {
                Console.WriteLine($"Name::{s}");
            }
            int value = (int)Status.Active;
            string str = Enum.GetName(typeof(Status), value);
            Console.WriteLine($"Name::{str}  Value::{value}");

            value = (int)Status.Inactive;
            str = Enum.GetName(typeof(Status), value);
            Console.WriteLine($"Name::{str}  Value::{value}");

            value = (int)Status.Open;
            str = Enum.GetName(typeof(Status), value);
            Console.WriteLine($"Name::{str}  Value::{value}");

            value = (int)Status.Closed;
            str = Enum.GetName(typeof(Status), value);
            Console.WriteLine($"Name::{str}  Value::{value}");

            value = (int)Status.Hold;
            str = Enum.GetName(typeof(Status), value);
            Console.WriteLine($"Name::{str}  Value::{value}");


            Console.ReadLine();
        }
    }
}
