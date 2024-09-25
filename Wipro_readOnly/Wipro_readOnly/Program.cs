using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_readOnly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadOnly objReadonly = new ReadOnly(1,2,3);
            Console.WriteLine($"X::{objReadonly.x}  Y::{objReadonly.y}  Z::{objReadonly.z}");

            ReadOnly objReadonly2 = new ReadOnly();
            objReadonly2.x = 22;
            Console.WriteLine($"X::{objReadonly2.x}   Y::{objReadonly2.y}  Z::{objReadonly2.z}");
            Console.ReadLine();
        }
    }

    public class ReadOnly
    {
        public  int x;
        public readonly int y = 32;
        public readonly int z;

        public ReadOnly()
        {
            z = 35;
        }
        public ReadOnly(int _x,int _y,int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
    }
}
