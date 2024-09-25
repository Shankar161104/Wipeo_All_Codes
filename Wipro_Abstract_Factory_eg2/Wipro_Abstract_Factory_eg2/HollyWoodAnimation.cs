using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory_eg2
{
    public class HollyWoodAnimation:HollyWoodMovie
    {
        public override string MovieName
        {
            get
            {
                return "KungFu Panda"; 
            }
        }
    }
}
