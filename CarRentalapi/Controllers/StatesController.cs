using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatesController : ControllerBase
    {
        private readonly StatesServices _statesServices;

        public StatesController(StatesServices statesServices)
        {
            _statesServices = statesServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var states = _statesServices.GetAllStates();
            return Ok(states);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var state = _statesServices.GetStateById(id);
            return Ok(state);
        }

        [HttpPost]
        public IActionResult AddState([FromBody] States state)
        {
            _statesServices.AddState(state);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteState(int id)
        {
            _statesServices.DeleteState(id);  
            return NoContent(); 
        }

        [HttpPut]
        public IActionResult UpdateState([FromBody] States state)
        {
            var updatedState = _statesServices.UpdateState(state);
            return Ok(updatedState);
        }
    }
}
