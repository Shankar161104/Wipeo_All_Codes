using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Abstract_Case_Study
{
    public class SilverLightTeam:IDotNetTeamFactory
    {
        public string GetTeam()
        {
            return "SilverLight team is ready to work for your projects";
        }
    }
}
