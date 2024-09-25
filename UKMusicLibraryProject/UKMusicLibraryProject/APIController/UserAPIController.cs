using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using System.Reflection.Metadata.Ecma335;
using UKMusicLibraryProject.DTO;

namespace UKMusicLibraryProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        IUserRepository userRepository;
        public UserAPIController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }

        [HttpGet("SingleUser")]

        public ActionResult GetSingleUsers(int id)
        {
            UserDTO userDTO = new UserDTO();
            User userEntity = userRepository.GetUser(id);
            userDTO.UserId = userEntity.UserID;
            userDTO.FirstName = userEntity.FirstName;
            userDTO.LastName = userEntity.LastName;
            userDTO.Email = userEntity.Email;
            userDTO.Address = userEntity.Address;
            userDTO.ContactNo = userEntity.ContactNo;
            userDTO.Password = userEntity.Password;
            userDTO.Name = userEntity.FirstName;
            userDTO.ArtistId = userEntity.ArtistId;

            return Ok(userDTO);
        }

        [HttpGet("ListUsers")]
        public ActionResult ListUsers()
        {
            List<UserDTO> lstUser = new List<UserDTO>();
            userRepository.GetUsers().ToList().ForEach(u =>
            {
                UserDTO userDTO = null;
                userDTO = new UserDTO()
                {
                    UserId = u.UserID,
                    UserName = u.UserName,
                    Email = u.Email,
                    Password = u.Password,
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Name = $"{u.FirstName}{u.LastName}",
                    ContactNo = u.ContactNo,
                    Address = u.Address,
                    ArtistId = u.ArtistId,
                };
                lstUser.Add(userDTO);
            });
            return Ok(lstUser);
        }

        [HttpGet("CreateUser")]

        public int Createuser(UserDToCreate model)
        {
            User userEntity = new User()
            {
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                FirstName = model.FirstName,
                Address = model.Address,
                ContactNo = model.ContactNo,
                LastName = model.LastName
            };
            userRepository.InsertUser(userEntity);
            return 1;

        }

        public int UpdateUser(UserDTO model)
        {
            User userEntity = new User()
            {
                UserID = model.UserId,
                UserName = model.UserName,
                Email = model.Email,
                Password = model.Password,
                FirstName = model.FirstName,
                Address = model.Address,
                ContactNo = model.ContactNo,
                LastName = model.LastName,
                ArtistId = model.ArtistId

            };
            userRepository.UpdateUser(userEntity);
            return 1;

        }

        public int DeletUser(long Id)
        {


            userRepository.DeleteUser(Id);
            return 1;

        }

    }
}
