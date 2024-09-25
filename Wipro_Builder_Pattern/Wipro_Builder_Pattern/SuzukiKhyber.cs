using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Builder_Pattern
{
    public class SuzukiKhyber:IBuilder
    {
        public SuzukiKhyber()
        {

        }
        public void ManufactureCar()
        {
            Console.WriteLine("Suzuki khyber model 2002 standard   Color Red   Air Conditioned   Alloy Rim"); 

        }
    }
}
