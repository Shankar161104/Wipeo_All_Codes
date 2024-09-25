using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_17_08_2024
{
    public class Factory
    {
        public IDataAdapter GetConnection(int type)
        {
            switch (type)
            {
                case 1:
                    return new SqlClient();
                case 2:
                    return new OracleClient();
                case 3:
                    return new MSAccessClient();
                default:
                    throw new ArgumentException("Invalid client type");
            }
        }
    }
}
