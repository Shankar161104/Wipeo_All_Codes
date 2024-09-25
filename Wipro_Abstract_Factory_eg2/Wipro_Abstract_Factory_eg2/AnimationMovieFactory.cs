using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory_eg2
{
    public class AnimationMovieFactory:MovieFactory
    {
        public override HollyWoodMovie GetHollyWoodMovie()
        {
            return new HollyWoodAnimation();
        }
        public override BollyWoodMovie GetBollyWoodMovie()
        {
            return new BollyWoodAnimation();
        }

    }
}
