using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Reflection_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            foreach (var type in types)
            {
                Console.WriteLine($"Class::{type.Name}");
                MethodInfo[] Methods = type.GetMethods();
                foreach(var method in Methods)
                {
                    Console.WriteLine($"Methods::{method.Name}");
                    ParameterInfo[] Parameters = method.GetParameters();
                    foreach(var param in Parameters)
                    {
                        Console.WriteLine($"Parameters::{param.Name}");
                    }
                }
            }
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student()
        {
            RollNo = 1;
            Name = "Shankar";
            Age = 22;
        }
        public Student(int _rollno, string _name,int _age )
        {
            RollNo = _rollno;
            Name = _name;
            Age = _age;
        }
        public void Study()
        {
            RollNo = 2;
            Name = "Jai";
            Age = 23;
            Console.WriteLine($"RollNO::{RollNo}  Name::{Name}  Age::{Age}");
        }
    }
}
