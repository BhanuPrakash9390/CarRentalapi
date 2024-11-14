using CarRentalapi.Models;
using CarRentalapi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRentalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeTypesController : ControllerBase
    {
        private readonly EmployeeTypesServices employeeTypesServices;
        public EmployeeTypesController(EmployeeTypesServices employeeTypes) 
        {
            this.employeeTypesServices = employeeTypes;
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var emp=employeeTypesServices.GetAllEmployeeTypes();
            return Ok(emp);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var emp=employeeTypesServices.GetEmployeeTypeById(id);
            return Ok(emp);
        }
        [HttpPost]
        public IActionResult AddEmployeeType([FromBody]EmployeeTypes employeeTypes)
        {
            employeeTypesServices.AddEmployeeType(employeeTypes);
            return Ok(employeeTypes);
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteEmployeeType(int id)
        {
            employeeTypesServices.DeleteEmployeeType(id);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateEmployeeType([FromBody]EmployeeTypes employeeTypes)
        {
            var updemp=employeeTypesServices.UpdateEmployeetype(employeeTypes);
            return Ok(updemp);
        }
    }
}
