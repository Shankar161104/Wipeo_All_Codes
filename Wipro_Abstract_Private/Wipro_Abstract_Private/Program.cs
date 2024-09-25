using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Private
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    

    public class User:Details
    {
        private int UserID ;
        private string UserName;
        private string UserEmail;
        private int UserPhone;

       

    }
    public abstract class Details
    {
        public abstract string City { get; set; }
        public abstract string Gender { get; set; }

    }
}
