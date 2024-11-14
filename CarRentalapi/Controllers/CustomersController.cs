using CarRentalapi.Models;
using CarRentalapi.Service;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly CustomersServices _customersServices;

        public CustomersController(CustomersServices customersServices)
        {
            _customersServices = customersServices;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var customers = _customersServices.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var customer = _customersServices.GetCustomerById(id);
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer([FromBody] Customers customer)
        {
            _customersServices.AddCustomer(customer);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateCustomer([FromBody] Customers customer)
        {
            var updatedCustomer = _customersServices.UpdateCustomer(customer);
            return Ok(updatedCustomer);
        }

        [HttpDelete("{id:int}")]
        public IActionResult DeleteCustomer(int id)
        {
            _customersServices.DeleteCustomer(id);
            return NoContent();
        }
    }
}
