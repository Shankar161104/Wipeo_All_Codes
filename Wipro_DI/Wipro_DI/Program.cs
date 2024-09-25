using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_DI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer objComputer = new Computer(new Processor(2,4));
            
            
            Console.WriteLine(objComputer);
            Console.ReadLine();
        }
    }

    public class Computer
    {
        Processor processor;
        public Computer(Processor _processor)//Constructor dependency
        {
            processor = _processor;
            Console.WriteLine("Computer class called");
        }
    }

    public class Processor
    {
        public Processor(int a,int b)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
            int c = a + b;
            Console.WriteLine(c);
            Console.WriteLine("Processor class called");
        }
    }
}
