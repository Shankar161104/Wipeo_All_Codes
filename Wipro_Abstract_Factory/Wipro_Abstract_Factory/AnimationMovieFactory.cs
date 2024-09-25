using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory
{
    public class AnimationMovieFactory:IMovieFactory
    {
        public IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodAnimation();
        }
        public IBollywoodMovie GetBollywodMovie()
        {
            return new BollywoodAnimation();
        }

        
    }
}
