using CarRentalapi.Models;
using CarRentalapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : ControllerBase
    {
        private readonly DriversServices services;
        public DriversController(DriversServices citiesServices)
        {
            services = citiesServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var driver=services.GetAllDrivers();
            return Ok(driver);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var driver= services.GetDriversById(id);
            return Ok(driver);
        }
        [HttpPost]
        public IActionResult AddDriver([FromBody] Drivers drivers)
        {
            services.AddDriver(drivers);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteDriver(int id)
        {
            services.DeleteDrivers(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateDriver([FromBody] Drivers drivers)
        {
            var updatedriver=services.UpdateDrivers(drivers);
            return Ok(updatedriver);
        }
    }
}
