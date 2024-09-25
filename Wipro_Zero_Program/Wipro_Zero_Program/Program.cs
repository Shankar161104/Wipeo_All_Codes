using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Zero_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the numner:");
            int i = Convert.ToInt32(Console.ReadLine());
            string s = Convert.ToString(i);
            string res = "";
            if (s[0] !='0')
            {
                res = '0' + s;
            }
            else
            {
                res = s;
            }
            Console.WriteLine($"The new number is {res}");
            Console.ReadLine();
        }


           

         }
    }

