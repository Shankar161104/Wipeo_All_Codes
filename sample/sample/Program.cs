using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Level.StudentID = 1;
            Level.StudentName = "Shankar";
            Level.StudentAge = 22;
            Console.WriteLine($"StudentID::{Level.StudentID}  StdeuntName::{Level.StudentName}  StudentAge::{Level.StudentAge}");
            int add=Level.Addition(1,2);
            Console.WriteLine(add);
            
        }
    }
    public abstract class Connection
    {

        public abstract string OpenConnection();

    }

    public class Connected : Connection
    {
        public override string OpenConnection()
        {
            return "Connection is open";
        }
    }

    public static class Level
    {
        public static int StudentID;
        public static string StudentName;
        public static int StudentAge;

        public static int Addition(int a,int b)
        {
            return a + b;
        }
         static Level()
        {
            Console.WriteLine("Static constructor called");

        }
    }
}
