using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(string);
            Console.WriteLine($"Name::{t.Name}");
            Console.WriteLine($"Full Name::{t.FullName}");
            Console.WriteLine($"Namespace::{t.Namespace}");
            Console.WriteLine($"Base Type::{t.BaseType}");
            Console.WriteLine($"Assembly name::{t.Assembly}");
            Console.WriteLine($"Assembly Qualified name::{t.AssemblyQualifiedName}");


            Type t1 = typeof(int);
            Console.WriteLine($"Name::{t.Name}");
            Console.WriteLine($"Full Name::{t.FullName}");
            Console.WriteLine($"Namespace::{t.Namespace}");
            Console.WriteLine($"BaseType::{t.BaseType}");
            Console.ReadLine();
        }
    }
}
