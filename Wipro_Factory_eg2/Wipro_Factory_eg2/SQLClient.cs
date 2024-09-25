using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_eg2
{
    public class SQLClient:IDataProvider
    {
        public int OpenConnection()
        {
            return 1;
        }
        public int CloseConnection()
        {
            return 1;
        }
    }
}
