using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Hybrid_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            objParent.Daddy();

            Child1 objChild1 = new Child1();
            objChild1.Daddy();
            objChild1.Son();

            Child2 objChild2 = new Child2();
            objChild2.Daddy();
            objChild2.Daughter();

            SubChild1 objSubChild1 = new SubChild1();
            objSubChild1.Daddy();
            objSubChild1.Son();
            objSubChild1.Grandson();

            SubChild2 objSubChild2 = new SubChild2();
            objSubChild2.Daddy();
            objSubChild2.Daughter();
            objSubChild2.GrandDaughter();

            Console.ReadLine();


        }
    }

    public class Parent 
    {
        public void Daddy() {

            Console.WriteLine("parent daddy method");
        }
    }

    public class Child1 : Parent 
    {
        public void Son()
        {
            Console.WriteLine("Child1 Son method");
        }
    }

    public class Child2 : Parent
    {
        public void Daughter()
        {
            Console.WriteLine("Child2 Daughter method");
        }
    }

    public class SubChild1 : Child1
    {
        public void Grandson()
        {
            Console.WriteLine("Subchild1 Grandson method");
        }
    }
    public class SubChild2 : Child2
    {
        public void GrandDaughter()
        {
            Console.WriteLine("SubChild2 GrandDaughter method");
        }
    }
}
