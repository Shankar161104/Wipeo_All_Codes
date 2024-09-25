using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_eg2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Factory objFactory = new Factory();
            Console.WriteLine("enter the integer value");
            int value = Convert.ToInt32(Console.ReadLine());
            IDataProvider objIData = objFactory.GetObject(value);
            if (objIData != null)
            {
                objIData.OpenConnection();
                objIData.CloseConnection();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number (1, 2, or 3).");
            }

            Console.ReadLine();
        }
    }
}
