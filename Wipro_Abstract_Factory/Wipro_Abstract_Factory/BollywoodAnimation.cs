using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory
{
    public class BollywoodAnimation:IBollywoodMovie
    {
        public string MovieName 
        {
            get
            {
                return "Arjun, The Warrior prince";
            }    

        }
    }
}
