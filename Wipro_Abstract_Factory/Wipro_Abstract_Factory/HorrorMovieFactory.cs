using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Abstract_Factory
{
    public class HorrorMovieFactory : IMovieFactory
    {
        public IHollywoodMovie GetHollywoodMovie()
        {
            return new HollywoodHorror();
        }
        public IBollywoodMovie GetBollywodMovie()
        {
            return new BollywoodHorror();
        }

       
    }
}
