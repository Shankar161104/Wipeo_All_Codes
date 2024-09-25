using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repositorty;
using Wipro_OnionArchitecture.DTO;

namespace Wipro_OnionArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserRepository iuserRepository;
        IUserProfileRepository iuserProfileRepository;

        public UserController(IUserRepository _iuserRepository,IUserProfileRepository _iuserProfileRepository)
        {
            iuserProfileRepository = _iuserProfileRepository;
            iuserRepository = _iuserRepository;
        }

        [HttpPost("CreateUser")]

        public int CreateUser(CreateUserDBO model)
        {
            User userEntity = new User();
            userEntity.UserName = model.UserName;
            userEntity.Email = model.Email;
            userEntity.Password = model.Password;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.Profile = new UserProfile();
            userEntity.Profile.FirstName = model.FirstName;
            userEntity.Profile.Address = model.Address;
            userEntity.Profile.ContactNo = model.ContactNo;
            userEntity.Profile.LastName = model.LastName;
            userEntity.Profile.ModifiedDate = DateTime.UtcNow;
            userEntity.Profile.IPAddress= Request.HttpContext.Connection.RemoteIpAddress.ToString();
            iuserRepository.InsertUser(userEntity);
            return 1;


        }


        [HttpPut("UpdateUser")]

        public int UpdateUser(UpdateUserDBO model)
        {
            User userEntity = new User();
            userEntity.Id = model.Id;
            userEntity.UserName = model.UserName;
            userEntity.Email = model.Email;
            userEntity.Password = model.Password;
            userEntity.ModifiedDate = DateTime.UtcNow;
            userEntity.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            userEntity.Profile = new UserProfile();
            userEntity.Profile.Id = model.Id;
            userEntity.Profile.FirstName = model.FirstName;
            userEntity.Profile.Address = model.Address;
            userEntity.Profile.ContactNo = model.ContactNo;
            userEntity.Profile.LastName = model.LastName;
            userEntity.Profile.ModifiedDate = DateTime.UtcNow;
            userEntity.Profile.IPAddress = Request.HttpContext.Connection.RemoteIpAddress.ToString();
            iuserRepository.UpdateUser(userEntity);
            return 1;


        }

        [HttpPut("DeleteUser")]

        public int DeleteUser(int id)
        {
            iuserRepository.DeleteUser(id);
            return 1;

        }

        [HttpGet("ListUsers")]

        public ActionResult ListUsers()
        {
            List<User> lstUser = new List<User>();
            var lstUsers = iuserRepository.GetUsers().ToList();
            foreach (var u in lstUsers)
            {
                User user = new User();
                UserProfile userProfile = iuserProfileRepository.GetUserProfile(u.Id);
                user.Id = u.Id;
                user.UserName = u.UserName;
                user.Email = u.Email;
                user.Password = u.Password;
                user.ModifiedDate= u.ModifiedDate;
                user.IPAddress = u.IPAddress;
                user.Profile = new UserProfile();
                user.Profile.FirstName = userProfile.FirstName;
                user.Profile.LastName = userProfile.LastName;
                user.Profile.ContactNo = userProfile.ContactNo;
                user.Profile.Address = userProfile.Address;
                user.Profile.ModifiedDate = userProfile.ModifiedDate;
                user.Profile.IPAddress = userProfile.IPAddress;

                user.Profile.Id = u.Id;
                lstUser.Add(user);





            }
            return Ok(lstUser);


        }
    }
}
