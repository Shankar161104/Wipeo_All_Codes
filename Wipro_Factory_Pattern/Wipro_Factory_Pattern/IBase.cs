using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Pattern
{
     interface IBase
    {
        void DoIt();
    }
    public class Derived1:IBase
    {
       public void DoIt()
        {
            Console.WriteLine("Derived 1");
        }
    }

    public class Derived2 : IBase
    {
        public void DoIt()
        {
            Console.WriteLine("Derived 2");
        }
    }

}
