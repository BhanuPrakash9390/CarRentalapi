using CarRentalapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCarRentals.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnersController : ControllerBase
    {
        private readonly OwnersServices _services;
        public OwnersController(OwnersServices ownersServices)
        {
            _services = ownersServices;
        }
        [HttpGet("GetALl")]
        public IActionResult GetAll()
        {
            var owner=_services.GetAllOwners();
            return Ok(owner);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var owner=_services.GetOwnerById(id);
            return Ok(owner);
        }
        [HttpPost]
        public IActionResult AddOwners([FromBody]Owners owners)
        {
            _services.AddOwner(owners);
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteOwners(int id)
        {
            _services.DeleteOwner(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateOwner([FromBody]Owners owners)
        {
            var owner=_services.UpdateOwner(owners);
            return Ok(owner);
        }
    }
}
