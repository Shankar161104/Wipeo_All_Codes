using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory objFactory = new Factory();
            IBase objBase = objFactory.GetBase(2);
            objBase.DoIt();

            Console.ReadLine();
        }
    }
}
