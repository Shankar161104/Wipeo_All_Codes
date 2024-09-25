using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using UKMusicLibraryProject.DTO;

namespace UKMusicLibraryProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginAPIController : ControllerBase
    {
        ILoginRepository loginRepository;
        public LoginAPIController(ILoginRepository _loginRepository)
        {
            loginRepository = _loginRepository;


        }

        [HttpGet("CheckListOfUsers")]
        public ActionResult CheckListOfUsers()
        {
            List<UserLoginDTO> lstUser = new List<UserLoginDTO>();
            loginRepository.GetUsers().ToList().ForEach(u =>
            {

                UserLoginDTO userLoginDTO = null;
                userLoginDTO = new UserLoginDTO()
                {
                    Id = u.UserID,
                    Email = u.Email,
                    Password = u.Password,
                    ArtistId = u.ArtistId
                };
                lstUser.Add(userLoginDTO);
            });
            return Ok(lstUser);
        }


    }
}
