using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Eg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Genpact objGenpact = new Genpact();
            int addition=objGenpact.Addition(1,2);
            string fullname = objGenpact.GetFullName("JAI","SHANKAR");
            objGenpact.Display("Lets go");
            Console.WriteLine($"Addition::{addition}  Fullname::{fullname}");



            MorganStanley objMorganStanley = new MorganStanley();
            string fullname1= objMorganStanley.GetFullName("MORGAN","STANLEY");
            Console.WriteLine($"Fullname::{fullname1}");

            TCS objTcs = new TCS();
            string fullname2=objTcs.GetFullName("RATAN", "TATA");
            Console.WriteLine($"Fullname::{fullname2}");

            Console.ReadLine();


        }
    }
}
