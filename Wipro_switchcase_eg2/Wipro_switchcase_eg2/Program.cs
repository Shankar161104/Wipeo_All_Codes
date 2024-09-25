using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wipro_switchcase_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            char ch;
            Console.WriteLine("enter the alphabet");
            ch = Convert.ToChar(Console.ReadLine());
        
            switch(char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("a is vowel");
                    break;
                case 'e':
                    Console.WriteLine("e is vowel");
                    break;
                case 'i':
                    Console.WriteLine("e is vowel");
                    break;
                case 'o':
                    Console.WriteLine("e is vowel");
                    break;
                case 'u':
                    Console.WriteLine("e is vowel");
                    break;
                default:
                    Console.WriteLine("It is a consonant");
                    break;


            }
            goto start;
            
           
            Console.ReadLine();
            
        }
       
    }
}
