using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_ClassLibrary
{
    public interface IConnection
    {
        string OpenConnection();
        string CloseConnection();
    }
}
