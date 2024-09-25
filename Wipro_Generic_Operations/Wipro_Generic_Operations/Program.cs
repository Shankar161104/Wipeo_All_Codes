using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Generic_Operations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Parent objParent = new Parent();
            int sum=objParent.Sum(1,2);
            Console.WriteLine(sum);
            int sub = objParent.Sub(4,2);
            Console.WriteLine(sub);
            Console.ReadLine();

            Lodu<T> objLodu = new Lodu<T>();

        }
    }

    public class Parent
    {
        public T Sum<T>(T x,T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a+b;
        }

        public T Sub<T>(T x,T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a - b;
        }

    }

    public class Lodu<T>
    {
        public int AreaRectangle<T>(T l,T w)
        {
            dynamic x = l;
            dynamic y = w;
            return x * y;
        }
    }
}
