using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Eg3
{
    public class Genpact:IWipro,IWiproForGenpact
    {
        public string GetFullName(string fname,string lname)
        {
            return fname + " " + lname;
        }
        public void Display(string str)
        {
           
            Console.WriteLine($"Hello {str}");
        }
        public int Addition(int a,int b)
        {
            int result = a + b;
            return result;
        }
    }
}
