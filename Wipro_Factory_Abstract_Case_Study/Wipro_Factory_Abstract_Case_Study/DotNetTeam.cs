using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Abstract_Case_Study
{
    public class DotNetTeam:IDotNetTeamFactory
    {
        public string GetTeam()
        {
            return "Dot Net Team is ready at your service";
        }
    }
}
