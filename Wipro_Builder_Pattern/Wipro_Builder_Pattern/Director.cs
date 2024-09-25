using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Builder_Pattern
{
    public class Director
    {
        public void ConstructorCar(IBuilder builder)
        {
            builder.ManufactureCar();
        }
    }
}
