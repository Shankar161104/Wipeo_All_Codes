using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wipro_Assessment_dll;

namespace Wipro_Assessment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*************ARITHMETIC PROGRAM******************");
            //ARITHMETIC PROGRAM

            Arithmetic objArithmetic = new Arithmetic();
            Console.WriteLine("enter the num1 value");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num1 value");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int addition = objArithmetic.Addition(num1,num2);
            Console.WriteLine($"The Addition is ::{addition}");

            int subtraction = objArithmetic.Subtraction(num1,num2);
            Console.WriteLine($"The Addition is ::{subtraction}");

            int multiplication = objArithmetic.Multiplication(num1,num2);
            Console.WriteLine($"The Multiplication is ::{multiplication}");

            int division = objArithmetic.Division(num1,num2);
            Console.WriteLine($"The Multiplication is ::{division}");




            Console.WriteLine("*************AREA PROGRAM******************");
            //AREA PROGRAM


            Area objArea = new Area();
            Console.WriteLine("enter the length value");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the width value");
            int width = Convert.ToInt32(Console.ReadLine());

            int rectarea = objArea.AreaRectangle(length, width);
            Console.WriteLine($"The area of rectangle is ::{rectarea}");

            Console.WriteLine("enter the side value");
            int side = Convert.ToInt32(Console.ReadLine());
            int squarearea = objArea.AreaSquare(side);
            Console.WriteLine($"The area od square is ::{squarearea}");

            Console.WriteLine("enter the radius value");
            int radius = Convert.ToInt32(Console.ReadLine());
            double circlearea = objArea.AreaCircle(radius);
            Console.WriteLine($"The area of circle is ::{circlearea}");

            Console.WriteLine("*************STRING OPERATION******************");
            //STRING OPERATION//

            StringOperation objfullname = new StringOperation();
            Console.WriteLine("enter the firstname");
            string firstname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the lastname");
            string lastname = Convert.ToString(Console.ReadLine());
            string fullname = objfullname.GetFullName(firstname,lastname);
            Console.WriteLine($"Fullname is {fullname}");


            //CUSTOMER PROGRAM

            Console.WriteLine("******************FIRST CUSTOMER*******************");

            Customer objCustomer = new Customer();
            Console.WriteLine("Enter the Customer ID");
            objCustomer.CustomerID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer Name");
            objCustomer.CustomerName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Customer Address");
            objCustomer.CustomerAddress = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Customer Email");
            objCustomer.CustomerEmail = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Customer ID::{objCustomer.CustomerID}  Customer Name::{objCustomer.CustomerName}  Customer Address::{objCustomer.CustomerAddress}  Customer Email::{objCustomer.CustomerEmail}");





            Console.WriteLine("******************SECOND CUSTOMER*******************");

            Customer objCustomer1 = new Customer();
            Console.WriteLine("Enter the Customer ID");
            objCustomer.CustomerID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Customer Name");
            objCustomer.CustomerName = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Customer Address");
            objCustomer.CustomerAddress = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter the Customer Email");
            objCustomer.CustomerEmail = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"Customer ID::{objCustomer.CustomerID}  Customer Name::{objCustomer.CustomerName}  Customer Address::{objCustomer.CustomerAddress}  Customer Email::{objCustomer.CustomerEmail}");












            Console.ReadLine();

        }
    }
}
