using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly CitiesServices _citiesServices;

        public CitiesController(CitiesServices citiesServices)
        {
            _citiesServices = citiesServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var cities = _citiesServices.GetAllCities();
            return Ok(cities);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var city = _citiesServices.GetCityById(id);
            return Ok(city);
        }

        [HttpPost]
        public IActionResult AddCity([FromBody] Cities city)
        {
            _citiesServices.AddCity(city);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCity(int id)
        {
            _citiesServices.DeleteCity(id);
            return NoContent(); 
        }

        [HttpPut]
        public IActionResult UpdateCity([FromBody] Cities city)
        {
            var updatedCity = _citiesServices.UpdateCity(city);
            return Ok(updatedCity);
        }
    }
}
