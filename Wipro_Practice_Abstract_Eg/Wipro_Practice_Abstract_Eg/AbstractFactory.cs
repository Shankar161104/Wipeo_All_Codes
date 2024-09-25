using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_Abstract_Eg
{
    public interface AbstractFactory
    {
        IButton GetAbstractButton();
        ICheckBox GetAbstractCheckBox();
    }
}
