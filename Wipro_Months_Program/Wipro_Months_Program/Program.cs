using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Months_Program
{
    internal class Program
    {
        public enum Months{January=1,February=2,March=3,April=4,May=5,June=6,July=7,August=8,September=9,October=10,November=11,December=12 }
        static void Main(string[] args)
        {
            int jan = (int)Months.January;
            int feb = (int)Months.February;
            int mar=(int)Months.March;
            int apr = (int)Months.April;
            int may=(int)Months.May;
            int jun = (int)Months.June;
            int jul = (int)Months.July;
            int aug = (int)Months.August;
            int sep = (int)Months.September;
            int oct = (int)Months.October;
            int nov = (int)Months.November;
            int dec = (int)Months.December;

            Console.WriteLine($"January is {jan}st month");
            Console.WriteLine($"February is {feb}st month");
            Console.WriteLine($"March is {mar}st month");
            Console.WriteLine($"April is {apr}st month");
            Console.WriteLine($"May is {may}st month");
            Console.WriteLine($"June is {jun}st month");
            Console.WriteLine($"July is {jul}st month");
            Console.WriteLine($"August is {aug}st month");
            Console.WriteLine($"September is {sep}st month");
            Console.WriteLine($"October is {oct}st month");
            Console.WriteLine($"November is {nov}st month");
            Console.WriteLine($"December is {dec}st month");
           
            foreach(string s in Enum.GetNames(typeof(Months)))
            {
                Console.WriteLine($"The Month would be ::{s}");
            }

            int num = (int)Months.January;
            string str = Enum.GetName(typeof(Months),num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.February;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.March;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.April;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.May;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.June;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.July;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.August;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.September;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.October;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");

            num = (int)Months.November;
            str = Enum.GetName(typeof(Months), num);
            Console.WriteLine($"{str}---> {num}");



            Console.ReadLine();
        }
    }
}
