using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    internal interface IUserProfileRepository
    {
        UserProfile GetUserProfile(long id);
    }
}
