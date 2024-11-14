using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleCapacityController : ControllerBase
    {
        private readonly VehicleCapacityServices _vehicleCapacityServices;

        public VehicleCapacityController(VehicleCapacityServices vehicleCapacityServices)
        {
            _vehicleCapacityServices = vehicleCapacityServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var vehicleCapacities = _vehicleCapacityServices.GetAllVehicleCapacities();
            return Ok(vehicleCapacities);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicleCapacity = _vehicleCapacityServices.GetVehicleCapacityById(id);
            return Ok(vehicleCapacity);
        }

        [HttpPost]
        public IActionResult AddVehicleCapacity([FromBody] VehicleCapacity vehicleCapacity)
        {
            _vehicleCapacityServices.AddVehicleCapacity(vehicleCapacity);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicleCapacity( [FromBody] VehicleCapacity vehicleCapacity)
        {
            var updatedVehicleCapacity = _vehicleCapacityServices.UpdateVehicleCapacity(vehicleCapacity);
            return Ok(updatedVehicleCapacity);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteVehicleCapacity(int id)
        {
            _vehicleCapacityServices.DeleteVehicleCapacity(id);
            return Ok();
        }
    }
}
