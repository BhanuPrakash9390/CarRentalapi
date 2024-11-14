using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;
using OnlineCarRentals.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly VehicleServices _vehicleServices;

        public VehicleController(VehicleServices vehicleServices)
        {
            _vehicleServices = vehicleServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var vehicles = _vehicleServices.GetAllVehicles();
            return Ok(vehicles);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicle = _vehicleServices.GetVehicleById(id);
            return Ok(vehicle);
        }

        [HttpPost]
        public IActionResult AddVehicle([FromBody] Vehicles vehicle)
        {
            _vehicleServices.AddVehicle(vehicle);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicle( [FromBody] Vehicles vehicle)
        {
            var updatedVehicle = _vehicleServices.UpdateVehicle(vehicle);
            return Ok(updatedVehicle);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteVehicle(int id)
        {
            _vehicleServices.DeleteVehicle(id);
            return Ok(); 
        }
    }
}
