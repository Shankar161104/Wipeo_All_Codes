using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wipro_Factory_Abstract_Case_Study
{
    public class Program
    {
        static void Main(string[] args)
        {
            DotNetTeams objGetTeam = new DotNetTeams();
            IDotNetTeamFactory objITeam = objGetTeam.GetTeam(SkillSets.Dotnet);
            Console.WriteLine(objITeam.GetTeam());

            Console.ReadLine();
        }
    }
}
