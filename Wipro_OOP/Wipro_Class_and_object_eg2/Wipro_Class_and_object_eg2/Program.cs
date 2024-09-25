using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Class_and_object_eg2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Console.WriteLine("Enter the ID of the person");
            person1.personID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the name of the person");
            person1.personName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the age of the person");
            person1.personAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the address of the person");
            person1.personAddress = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the Email of the person ");
            person1.personEmail = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the phone number of the person");
            person1.personPhone = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine($"Person ID:: {person1.personID}  Person Name::{person1.personName}  Person age::{person1.personAge}  Person Address::{person1.personAddress} Person Email::{person1.personEmail}  Person Phone::{person1.personPhone}");
            Console.ReadLine();
        }
    }
    public class Person
    {
        public int personID;
        public string personName;
        public int personAge;
        public string personAddress;
        public string personEmail;
        public int personPhone;
    }
}
