using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child objChild = new Child();
            objChild.Daddy();
            objChild.Son();
            Console.ReadLine();

        }
    }

    public class Parent
    {
        public void Daddy()
        {
            Console.WriteLine("Parent class Daddy method");
        }
    }

    public class Child : Parent
    {
        public void Son ()
        {
            Console.WriteLine("Child class Son method");
        }
    }
}
