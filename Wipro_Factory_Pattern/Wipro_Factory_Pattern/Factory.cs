using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Pattern
{
     class Factory
    {
        public IBase GetBase(int type)
        {
            IBase base1 = null;

            switch(type)
            {
                case 1:
                    base1 = new Derived1();
                    break;
                case 2:
                    base1 = new Derived2();
                    break;
            }

            return base1;
        }
    }
}
