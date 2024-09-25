using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public class MacOSUIButton:IButton,ICheckBox
    {
        public string GetButton()
        {
            return "MacOSUI Button Clicked";
        }

        public string GetCheckBox()
        {
            return "MacOSUI check box";
        }
    }
}
