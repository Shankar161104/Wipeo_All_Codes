using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Practice_ClassLibrary
{
    public class Connection:IConnection
    {
        public string OpenConnection()
        {
            return "Open Connetion";
        }
        public string CloseConnection()
        {
            return "Close Connection";
        }
    }
}
