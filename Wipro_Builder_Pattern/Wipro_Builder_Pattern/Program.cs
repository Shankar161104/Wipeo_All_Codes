using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Builder_Pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Director objDirector = new Director();
            IBuilder mehranBuilder = new SuzukiMehran();
            objDirector.ConstructorCar(mehranBuilder);

            IBuilder khyberBuilder = new SuzukiKhyber();
            objDirector.ConstructorCar(khyberBuilder);
            Console.ReadLine();
        }
    }
}
