using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Multilevel_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GrandParent objGrandpa = new GrandParent();
            objGrandpa.Grandpa();

            Parent objParent = new Parent();
            objParent.Grandpa();
            objParent.Daddy();


            Child objChild = new Child();
            objChild.Grandpa();
            objChild.Daddy();
            objChild.Kid();
            Console.ReadLine();
        }
    }

    public class GrandParent
    {
        public void Grandpa()
        {
            Console.WriteLine("Grandparent Grandpa method invoked");
        }
    }
    public class Parent : GrandParent
    {
        public void Daddy()
        {
            Console.WriteLine("Parent Daddy method invoked");
        }
    }

    public class Child : Parent
    {
        public void Kid()
        {
            Console.WriteLine("Child Kid method invoked");
        }
    }
}
