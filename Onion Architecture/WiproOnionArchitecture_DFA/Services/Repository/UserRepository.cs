






using DAL.EntityFrameWork;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{

    public class UserRepository : IUserRepository
    {
        private readonly WiproOnionArchitectureDfaContext
        public void DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public UserProfile GetUserProfile(long id)
        {
            throw new NotImplementedException();
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
