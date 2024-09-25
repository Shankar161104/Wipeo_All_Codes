using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;

namespace UKMusicLibraryProject.APIController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistAPIController : ControllerBase
    {
        private Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment;
        IArtistRepository iartistRepository;

        public ArtistAPIController()
        {

        }
    }
}
