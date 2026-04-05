using Microsoft.AspNetCore.Mvc;
using SampleDI.Models;
using SampleDI.Services;

namespace SampleDI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployeeService _employeeService;

        // DI through constructor
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // Get employees through service method
        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(_employeeService.GetEmployees());
        }

        // Add employee through service method
        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee emp)
        {
            try
            {
                return Ok(_employeeService.AddEmployee(emp));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
