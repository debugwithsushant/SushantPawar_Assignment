using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> empList = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ram", Salary = 35000 },
            new Employee { Id = 2, Name = "Vishal", Salary = 60000},
            new Employee { Id = 3, Name = "Pavan", Salary = 25000 },
        };

        [HttpGet]
        public ActionResult<List<Employee>> GetEmployees()
        {
            return Ok(empList);
        }

        [HttpPost]
        public ActionResult<Employee> AddEmployee([FromBody] Employee newEmp)
        {
            if (newEmp.Id <= 0)
            {
                return BadRequest("Employee id must be greater than zero...");
            }

            if (string.IsNullOrEmpty(newEmp.Name))
            {
                return BadRequest("Employee name must not be NULL or Space");
            }

            if (newEmp.Salary <= 0)
            {
                return BadRequest("Employee salary must be greater than zero...");
            }

            empList.Add(newEmp);
            return Ok(empList);
        }
    }
}
