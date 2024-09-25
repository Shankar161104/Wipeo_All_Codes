using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public class LinuxFactory:AbstractFactory
    {
        public IButton GetAbstractButton()
        {
            return new LinuxButton();
        }

        public ICheckBox GetAbstractCheckBox()
        {
            return new LinuxButton();
        }

    }
}
