using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FifthWebApi.Models;

namespace FifthWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees =
        [
            new Employee
            {
                Id=1,
                Name="Sai",
                Salary=50000
            },

            new Employee
            {
                Id=2,
                Name="Rahul",
                Salary=60000
            }
        ];

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }
    }
}