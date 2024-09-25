using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_CSharp_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Path = @"C:\Wipro_DotNet\myFile.txt";
            FileStream objFile = File.Create(Path);
            if (File.Exists(Path))
            {
                Console.WriteLine("File is present");
            }
            else
            {
                Console.WriteLine("File is not present");
            }

            objFile.Close();
            objFile = File.Open(Path,FileMode.Open);
            Console.WriteLine("OPened Successfullly");



            Console.ReadLine();
        }
        
    }
}
