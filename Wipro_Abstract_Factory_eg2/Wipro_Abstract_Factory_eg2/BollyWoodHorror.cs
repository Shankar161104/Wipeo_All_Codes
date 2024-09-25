using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory_eg2
{
    public class BollyWoodHorror:BollyWoodMovie
    {
        public override string MovieName
        {
            get
            {
                return "Shaapit";
            }
        }
    }
}
