using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly WiproOnionArchitectureDfaContext wiproOnionArchitectureDfaContext;
        public UserRepository(WiproOnionArchitectureDfaContext _wiproOnionArchitectureDfaContext)
        {
            wiproOnionArchitectureDfaContext = _wiproOnionArchitectureDfaContext;
        }

        public void DeleteUser(int id)
        {
            UserProfile userProfile = wiproOnionArchitectureDfaContext.UserProfiles.SingleOrDefault(p => p.UserId == id);
            wiproOnionArchitectureDfaContext.UserProfiles.Remove(userProfile);


            User user = wiproOnionArchitectureDfaContext.Users.SingleOrDefault(user => user.UserId == id);
            wiproOnionArchitectureDfaContext.Users.Remove(user);


            wiproOnionArchitectureDfaContext.SaveChanges();


        }

        public IEnumerable<User> GetUsers()
        {
            return wiproOnionArchitectureDfaContext.Users.ToList();

        }

        public void InsertUser(User user)
        {
            wiproOnionArchitectureDfaContext.Users.Add(user);
            wiproOnionArchitectureDfaContext.SaveChanges();


        }

        public void UpdateUser(User user)
        {
            wiproOnionArchitectureDfaContext.Users.Update(user);
            wiproOnionArchitectureDfaContext.SaveChanges();
           

        }
    }
}
