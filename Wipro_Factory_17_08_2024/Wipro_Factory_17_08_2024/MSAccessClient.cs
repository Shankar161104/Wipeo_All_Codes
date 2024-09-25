using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_17_08_2024
{
    public class MSAccessClient:IDataAdapter
    {
        public int OpenConnection()
        {
            Console.WriteLine("Open connection in MSAccess");
            return 1;
        }

        public int CloseConnection()
        {
            Console.WriteLine("Close connection in MSAccess");
            return 1;
        }

    }
}
