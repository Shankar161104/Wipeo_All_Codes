using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Method_Overloading_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations objOperations = new Operations();
            Console.WriteLine("enter the a value");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the b value");
            int b = Convert.ToInt32(Console.ReadLine());
            int addInt = objOperations.Add(a,b);
            Console.WriteLine($"Int ADD::{addInt}");


            Console.WriteLine("Enter the a1 value");
            float a1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the b1 value");
            float b1 = float.Parse(Console.ReadLine());
            float addFloat = objOperations.Add(a1,b1);
            Console.WriteLine($"float FLOAT::{addFloat}");


            Console.WriteLine("Enter the a1 value");
            string a2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the b1 value");
            string b2 =Convert.ToString(Console.ReadLine());
            string addString = objOperations.Add(a2,b2);
            Console.WriteLine($"Int STRING::{addString}");




            Console.ReadLine();


        }
    }

    public class Operations
    {
        public int Add(int a,int b)
        {
            return a + b;
        }

        public float Add(float a,float b)
        {
            return a + b;
        }
        public string Add(string a,string b)
        {
            return a + " " + b;
        }
        public decimal Add(decimal a,decimal b)
        {
            return a + b;
        }
    }
}
