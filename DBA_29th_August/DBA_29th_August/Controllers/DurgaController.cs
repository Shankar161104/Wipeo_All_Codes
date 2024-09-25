using DBA_29th_August.Models;
using DBA_29th_August.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DBA_29th_August.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DurgaController : ControllerBase
    {
        private readonly IDurgaRepository durgaRepository;
        public DurgaController(IDurgaRepository _durgaRepository)
        {
            durgaRepository = _durgaRepository;
        }

        [HttpPost("CreateDurga")]
        public ActionResult CreateDurga(Durga durga)
        {
            return Ok(durgaRepository.CreateDurga(durga));
        }

        [HttpGet("UpdateDurga")]

        public ActionResult UpdateDurga(Durga durga)
        {
            return Ok(durgaRepository.UpdateDurga(durga));
        }

        [HttpPost("ListOfDurga")]

        public ActionResult GetDurga()
        {
            return Ok(durgaRepository.GetDurga());
        }
    }
}
