using Microsoft.AspNetCore.Http;
using Wipro_API_CodeFirstApproach.Repository;
using Wipro_API_CodeFirstApproach.Model;
using Wipro_API_CodeFirstApproach.Entity_Framework;
using Microsoft.AspNetCore.Mvc;

namespace Wipro_API_CodeFirstApproach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {

        private readonly IVehicleService ivehicleService;

        public VehicleController(IVehicleService _ivehicleService)
        {
            ivehicleService = _ivehicleService;
        }

        [HttpPost("CreateVehicle")]

        public ActionResult CreateVehicle(Vehicle vehicle)
        {
            return Ok(ivehicleService.CreateVehicle(vehicle));
        }

        [HttpPost("VehicleList")]

        public ActionResult GetVehicleList()
        {
            return Ok(ivehicleService.GetVehicle());
        }

        [HttpPost("SearchVehicleByID")]

        public ActionResult SearchVehicle(int VehicleID)
        {
            return Ok(ivehicleService.SearchVehicle(VehicleID));
        }

        [HttpPost("UpdateVehicle")]

        public ActionResult UpdateVehicle(Vehicle vehicle)
        {
            return Ok(ivehicleService.UpdateVehicle(vehicle));
        }

        [HttpPost("DeleteVehicle")]

        public ActionResult DeleteVehicle(int vehicle)
        {
            return Ok(ivehicleService.DeleteVehicle(vehicle));
        }


    }
}
