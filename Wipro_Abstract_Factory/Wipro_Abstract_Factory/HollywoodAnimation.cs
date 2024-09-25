using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory
{
    public class HollywoodAnimation:IHollywoodMovie
    {
        public string MovieName
        {
            get
            {
                return "Kungfu Panda";
            }
        }
    }
}
