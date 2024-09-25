using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Single_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student objStudent = new Student();
            objStudent.Study();
            objStudent.Teach();
            Console.ReadLine();
        }
    }

    public class Teacher {
        public void Teach()
        {
            Console.WriteLine("Teacher teach method");
        }
    }

    public class  Student:Teacher
    {
        public void Study()
        {
            Console.WriteLine("Student study method");
        }
    }
}
