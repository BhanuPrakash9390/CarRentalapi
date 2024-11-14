using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleMakesController : ControllerBase
    {
        private readonly VehicleMakesServices _vehicleMakesServices;

        public VehicleMakesController(VehicleMakesServices vehicleMakesServices)
        {
            _vehicleMakesServices = vehicleMakesServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var vehicleMakes = _vehicleMakesServices.GetAllVehicleMakes();
            return Ok(vehicleMakes);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicleMake = _vehicleMakesServices.GetVehicleMakeById(id);
            return Ok(vehicleMake);
        }

        [HttpPost]
        public IActionResult AddVehicleMake([FromBody] VehicleMakes vehicleMake)
        {
            _vehicleMakesServices.AddVehicleMake(vehicleMake);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicleMake([FromBody] VehicleMakes vehicleMake)
        {
            var updatedVehicleMake = _vehicleMakesServices.UpdateVehicleMake(vehicleMake);
            return Ok(updatedVehicleMake);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteVehicleMake(int id)
        {
            _vehicleMakesServices.DeleteVehicleMake(id);
            return Ok(); 
        }
    }
}
