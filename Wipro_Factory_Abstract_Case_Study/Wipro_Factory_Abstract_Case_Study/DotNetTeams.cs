using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Abstract_Case_Study
{
    public class DotNetTeams
    {
        public IDotNetTeamFactory GetTeam(SkillSets SkillType)
        {
            switch (SkillType)
            {
                case SkillSets.Dotnet:
                    return new DotNetTeam();
                case SkillSets.SilverLight:
                    return new SilverLightTeam();
            }
            return null; ;

        }
    }
}
