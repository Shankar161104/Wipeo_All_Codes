using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            objParent.Display();
            Child objChild = new Child();
            objChild.Display();

            Parent objParent1 = new Child();
            objParent1.Display();

           
            Console.ReadLine();
        }
    }

    public class Parent
    {
        public virtual void Display()
        {
            Console.WriteLine("Parent method called");
        }
    }

    public class Child : Parent
    {
        public override void Display()
        {
            Console.WriteLine("Parent method gor overrided here in child class");
        }
    }
}
