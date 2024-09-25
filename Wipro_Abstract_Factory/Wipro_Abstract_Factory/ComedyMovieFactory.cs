using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory
{
    public class ComedyMovieFactory: IMovieFactory
    {
        public IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodComedy();
        }
        public IBollywoodMovie GetBollywodMovie()
        {
            return new BollywoodComedy();
        }

        
    }
}
