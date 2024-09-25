using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.GetInstance();

            string open = logger.OpenConnection();
            Console.WriteLine(open);
            int add=logger.Addition(1,2);
            Console.WriteLine($"ADDITION::{add}");
            
           
            logger.Log("Using Log Method with logger object");



            Logger logger2 = Logger.GetInstance();
           
            add=logger2.Addition(3,4);
            Console.WriteLine($"ADDITION::{add}");
            open=logger2.CloseConnection();
            logger.Log("Using Log Method with logger2 object");
            Console.WriteLine(open);
            


            Console.ReadLine();
        }
    }
}
