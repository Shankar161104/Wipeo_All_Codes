using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_Enum_withswitch
{
    internal class Program
    {
        public enum Days { Sunday,Monday,tuesday,Wednesday,Thursday,Friday,Saturday}
        static void Main(string[] args)
        {
        start:

            Console.WriteLine("enter the value of the day");
            int day = Convert.ToInt32(Console.ReadLine());
      
            switch (day)
            {
                case 0:
                    string str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;
                case 1:
                    str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;

                case 2:
                    str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;
                case 3:
                    str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;
                case 4:
                    str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;
                case 5:
                    str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;
                case 6:
                    str = Enum.GetName(typeof(Days), day);
                    Console.WriteLine($"day is {str}");
                    break;
                default:
                    Console.WriteLine("invalid");
                    break;

            }
            goto start;
           
            Console.ReadLine();
        }
    }
}
