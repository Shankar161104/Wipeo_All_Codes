using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Singleton_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton objSingleton = Singleton.Instance;
            Console.WriteLine(objSingleton);

            Console.ReadLine();
        }
    }
    public sealed class Singleton
    {
        private Singleton()
        {

        }
        private static Singleton instance = null;
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}


