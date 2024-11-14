using CarRentalapi.Models;
using CarRentalapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {

        private readonly CountriesServices _countriesServices;

        public CountriesController(CountriesServices countriesServices)
        {
            _countriesServices = countriesServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var countriess=_countriesServices.GetAllCountries();
            return Ok(countriess);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var country = _countriesServices.GetCountryById(id);
            return Ok(country);
        }
        [HttpPost]
        public IActionResult AddCountries([FromBody] Countries countries)
        {
            _countriesServices.AddCountries(countries);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteById(int id)
        {
            var countrydel= _countriesServices.GetCountryById(id);
            return Ok(countrydel);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Countries countries)
        {
            var updatedcountry=_countriesServices.UpdateCountries(countries);
            return Ok(updatedcountry);
        }

    }
}
