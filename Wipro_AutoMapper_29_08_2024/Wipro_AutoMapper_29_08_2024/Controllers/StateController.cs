using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_AutoMapper_29_08_2024.Models;
using Wipro_AutoMapper_29_08_2024.Repository;

namespace Wipro_AutoMapper_29_08_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateRepository stateRepository;
        public StateController(IStateRepository _stateRepository)
        {
            stateRepository = _stateRepository;
        }

        [HttpPost("CreateState")]

        public ActionResult CreateState(State state)
        {
            return Ok(stateRepository.CreateState(state));
        }

        [HttpPost("UpdateState")]

        public ActionResult UpdateState(State state)
        {
            return Ok(stateRepository.UpdateState(state));
        }


        [HttpPost("DeleteState")]

        public ActionResult DeleteState(State state)
        {
            return Ok(stateRepository.DeleteState(state));
        }


        [HttpPost("ListOfStates")]
        public ActionResult GetStates()
        {
            return Ok(stateRepository.GetStates());
        }


        [HttpPost("SearchState")]

        public ActionResult SearchState(int id)
        {
            return Ok(stateRepository.SearchState(id));
        }




    }
}
