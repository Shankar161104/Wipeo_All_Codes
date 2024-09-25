using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_male_female
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] ch = {'m','f', 'm', 'f', 'm', 'f', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in ch)
            {
                if (g == 'm')
                 male++;
                else if (g == 'f')
                 female++;
                
               
            }
            Console.WriteLine(male);
            Console.WriteLine(female);
            Console.ReadLine();
        }
    }
}
