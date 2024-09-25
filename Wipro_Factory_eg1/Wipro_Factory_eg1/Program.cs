using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_eg1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

        start:
            Factory objFactory = new Factory();
            Console.WriteLine("enter the integer value");
            int value = Convert.ToInt32(Console.ReadLine());
            IBase objIBase = objFactory.GetObject(value);
            if (objIBase != null)
            {
                objIBase.Icecream();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number (1, 2, or 3).");
            }

            Console.ReadLine();

            goto start;
        }
        
    }
}
