using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory_eg2
{
    public abstract class MovieFactory
    {
      public abstract HollyWoodMovie GetHollyWoodMovie();
        public abstract BollyWoodMovie GetBollyWoodMovie();

    }
}
