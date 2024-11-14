using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleModelsController : ControllerBase
    {
        private readonly VehicleModelsServices _vehicleModelsServices;

        public VehicleModelsController(VehicleModelsServices vehicleModelsServices)
        {
            _vehicleModelsServices = vehicleModelsServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var vehicleModels = _vehicleModelsServices.GetAllVehicleModels();
            return Ok(vehicleModels);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var vehicleModel = _vehicleModelsServices.GetVehicleModelById(id);
            return Ok(vehicleModel);
        }

        [HttpPost]
        public IActionResult AddVehicleModel([FromBody] VehicleModels vehicleModel)
        {
            _vehicleModelsServices.AddVehicleModel(vehicleModel);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateVehicleModel( [FromBody] VehicleModels vehicleModel)
        {
            var updatedVehicleModel = _vehicleModelsServices.UpdateVehicleModel(vehicleModel);
            return Ok(updatedVehicleModel);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteVehicleModel(int id)
        {
            _vehicleModelsServices.DeleteVehicleModel(id);
            return Ok();
        }
    }
}
