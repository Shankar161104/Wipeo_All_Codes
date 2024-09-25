using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public class WindowsFaxctory:AbstractFactory
    {
        public IButton GetAbstractButton()
        {
            return new WindowsButton();
        }
        public ICheckBox GetAbstractCheckBox()
        {
            return new WindowsButton();
        }
    }
}
