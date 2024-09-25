using System;

namespace Wipro_prog2
{
    internal class Program_1
    {
        static void Main(string[] args)
        {
            int i = 20;
            Console.WriteLine($"The value of i is:: {i}");
            Console.WriteLine("The value of i is"+ i);
            Console.WriteLine("The value of i is {0}", i);

            String str = "Shankar";
            Console.WriteLine($"My name is  {str} ");
            Console.WriteLine("My name is " +str);
            Console.WriteLine("My name is {0}",str);

            bool b = true;
            Console.WriteLine($"It is {b} that I passed the exam ");
            Console.WriteLine("It is "+b+"that I passed the exam");
            Console.WriteLine("It is {0 }",b+"that I passed the exam");

            float f = 3.14f;
            Console.WriteLine($"The value of pi is : {f}");
            Console.WriteLine("The value of pi is " + f);
            Console.WriteLine("The value of pi is {0}",f);

            double d = 2.33d;
            Console.WriteLine($"The value of d is : {d}");
            Console.WriteLine("The value of d is"+d);
            Console.WriteLine("The value of d is {0}",d);

            char c = 'j';
            Console.WriteLine($"The character is :{c}");
            Console.WriteLine("The character is " + c);
            Console.WriteLine("The character is {0} ", c);

            decimal dec = 15535353.1423546454534M;
            Console.WriteLine($"The value of decimal is : {dec}");
            Console.WriteLine("The value of decimal is "+dec);
            Console.WriteLine("The value of decimal is{0 } ",dec);

            
            
            Console.ReadLine();
        }
    }
}
