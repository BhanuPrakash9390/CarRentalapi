using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleTypesController : ControllerBase
    {
        private readonly VehicleTypesServices _vehicleTypesServices;

        public VehicleTypesController(VehicleTypesServices vehicleTypesServices)
        {
            _vehicleTypesServices = vehicleTypesServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var vehicleTypes = _vehicleTypesServices.GetAllVehicleTypes();
            return Ok(vehicleTypes);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicleType = _vehicleTypesServices.GetVehicleTypeById(id);
            return Ok(vehicleType);
        }

        [HttpPost]
        public IActionResult AddVehicleType([FromBody] VehicleTypes vehicleType)
        {
            _vehicleTypesServices.AddVehicleType(vehicleType);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicleType( [FromBody] VehicleTypes vehicleType)
        {
            var updatedVehicleType = _vehicleTypesServices.UpdateVehicleType(vehicleType);
            return Ok(updatedVehicleType);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteVehicleType(int id)
        {
            _vehicleTypesServices.DeleteVehicleType(id);
            return Ok(); 
        }
    }
}
