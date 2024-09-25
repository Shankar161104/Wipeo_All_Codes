using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly WiproOnionArchitectureDfaContext wiproOnionArchitectureDfaContext;
        public UserProfileRepository(WiproOnionArchitectureDfaContext _wiproOnionArchitectureDfaContext)
        {
            wiproOnionArchitectureDfaContext = _wiproOnionArchitectureDfaContext;
        }
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserProfile GetUserProfile(long id)
        {
            return wiproOnionArchitectureDfaContext.UserProfiles.FirstOrDefault(s => s.UserId == id);
        }

        public void InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
