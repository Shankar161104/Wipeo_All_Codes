using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_eg1
{
    public class Factory
    {
        public IBase GetObject(int type)
        {
            IBase base1 = null;
            switch (type)
            {
                case 1:
                    base1 = new Strawberry();
                    break;
                case 2:
                    base1 = new Vanilla();
                    break;
                case 3:
                    base1 = new Chocolate();
                    break;
            }
            return base1;
        }
    }
}
