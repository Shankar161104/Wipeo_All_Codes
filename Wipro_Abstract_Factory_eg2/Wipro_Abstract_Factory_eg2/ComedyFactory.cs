using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory_eg2
{
    public class ComedyFactory:MovieFactory
    {
        public override HollyWoodMovie GetHollyWoodMovie()
        {
            return new HollyWoodComedy();
        }
        public override BollyWoodMovie GetBollyWoodMovie()
        {
            return new BollyWoodComedy();
        }
    }
}
