using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        // GET: api/employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = new List<object>
            {
                new { Id = 1, Name = "Alice", Department = "IT", Salary = 50000 },
                new { Id = 2, Name = "Bob", Department = "HR", Salary = 40000 }
            };

            return Ok(employees);
        }

        // GET: api/employee/1
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = new { Id = id, Name = "Sample Employee", Department = "IT" };
            return Ok(employee);
        }

        // POST: api/employee
        [HttpPost]
        public IActionResult AddEmployee([FromBody] object employee)
        {
            return Ok(new { message = "Employee added successfully" });
        }
    }
}
