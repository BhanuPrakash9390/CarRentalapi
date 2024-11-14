using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;
using CarRentalapi.Models;
using System;
using OnlineCarRentals.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalsController : ControllerBase
    {
        private readonly RentalsServices _rentalsServices;

        public RentalsController(RentalsServices rentalsServices)
        {
            _rentalsServices = rentalsServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var rentals = _rentalsServices.GetAllRentals();
            return Ok(rentals);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var rental = _rentalsServices.GetRentalById(id);
            return Ok(rental);
        }

        [HttpPost]
        public IActionResult AddRental([FromBody] Rentals rental)
        {
            _rentalsServices.AddRental(rental);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRental( [FromBody] Rentals rental)
        {
            var updatedRental = _rentalsServices.UpdateRental(rental);
            return Ok(updatedRental);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteRental(int id)
        {
            _rentalsServices.DeleteRental(id);
            return Ok();
        }

        [HttpGet("Customers/{customerId:int}")]
        public IActionResult GetRentalsByCustomerId(int customerId)
        {
            var rentals = _rentalsServices.GetRentalsByCustomerId(customerId);
            return Ok(rentals);
        }

        [HttpGet("Vehicles/{vehicleId:int}")]
        public IActionResult GetRentalsByVehicleId(int vehicleId)
        {
            var rentals = _rentalsServices.GetRentalsByVehicleId(vehicleId);
            return Ok(rentals);
        }

        [HttpGet("daterange")]
        public IActionResult GetRentalsByDateRange([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var rentals = _rentalsServices.GetRentalsByDateRange(startDate, endDate);
            return Ok(rentals);
        }
    }
}
