using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public class LinuxButton:IButton,ICheckBox
    {
        public string GetButton()
        {
            return "Linux Button Clicked";
        }

        public string GetCheckBox()
        {
            return "Linux check box";
        }
    }
}
