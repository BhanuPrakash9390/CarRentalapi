using CarRentalapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineCarRentals.Models;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeesServices _employeesServices;
        public EmployeesController(EmployeesServices employeesServices)
        {
            _employeesServices = employeesServices;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var employee=_employeesServices.GetAllEmployees();
            return Ok(employee);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var employee=_employeesServices.GetEmployeeById(id);
            return Ok(employee);
        }
        [HttpPost]
        public IActionResult AddEmployee([FromBody]Employee employee)
        {
            _employeesServices.AddEmployee(employee);
            return Ok(employee);
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeesServices.DeleteEmployee(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult UpdateEmployee([FromBody]Employee employee)
        {
            var updateemp= _employeesServices.UpdateEmployee(employee);
            return Ok(updateemp);
        }
    }
}
