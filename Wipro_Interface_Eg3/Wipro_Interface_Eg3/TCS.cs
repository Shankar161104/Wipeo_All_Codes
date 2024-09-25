using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Interface_Eg3
{
    public class TCS:IWipro
    {
        public string GetFullName(string fname, string lname)
        {
            return fname + " " + lname;
        }
        public void Display(string str)
        {
            str = "Shankar";
            Console.WriteLine(str);
        }
    }
}
