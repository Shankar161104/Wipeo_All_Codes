using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public class WindowsButton:IButton,ICheckBox
    {
        public string GetButton()
        {
            return "Windows Button Clicked";
        }

        public string GetCheckBox()
        {
            return "Windows check box";
        }
    }
}
