using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_17_08_2024
{
    public class OracleClient:IDataAdapter
    {
        public int OpenConnection()
        {

            Console.WriteLine("Open Connection in Oracle");
            return 1;

        }

        public int CloseConnection()
        {

            Console.WriteLine("Close Connection in Oracle");
            return 1;

        }
    }
}
