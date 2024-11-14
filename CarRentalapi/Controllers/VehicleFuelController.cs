using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleFuelController : ControllerBase
    {
        private readonly VehicleFuelServices _vehicleFuelServices;

        public VehicleFuelController(VehicleFuelServices vehicleFuelServices)
        {
            _vehicleFuelServices = vehicleFuelServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var vehicleFuels = _vehicleFuelServices.GetAllVehicleFuels();
            return Ok(vehicleFuels);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicleFuel = _vehicleFuelServices.GetVehicleFuelById(id);
            return Ok(vehicleFuel);
        }

        [HttpPost]
        public IActionResult AddVehicleFuel([FromBody] VehicleFuel vehicleFuel)
        {
            _vehicleFuelServices.AddVehicleFuel(vehicleFuel);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicleFuel([FromBody] VehicleFuel vehicleFuel)
        {
            var updatedVehicleFuel = _vehicleFuelServices.UpdateVehicleFuel(vehicleFuel);
            return Ok(updatedVehicleFuel);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteVehicleFuel(int id)
        {
            _vehicleFuelServices.DeleteVehicleFuel(id);
            return Ok();
        }
    }
}
