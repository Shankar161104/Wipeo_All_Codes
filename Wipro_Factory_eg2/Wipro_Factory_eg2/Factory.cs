using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_eg2
{
    public class Factory
    {
        public IDataProvider GetObject(int type)
        {
            IDataProvider provider = null;
            switch (type)
            {
                case 1:
                    provider = new MSAccessClient();
                    break;
                case 2:
                    provider = new OracleClient();
                    break;

                case 3:
                    provider = new SQLClient();
                    break;

            }
            return provider;
        }
    }
}
