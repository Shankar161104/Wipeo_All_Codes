using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_17_08_2024
{
    public interface IDataAdapter
    {
        int OpenConnection();
        int CloseConnection();
    }
}
