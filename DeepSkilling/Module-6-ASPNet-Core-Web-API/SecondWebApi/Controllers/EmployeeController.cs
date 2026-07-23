using Microsoft.AspNetCore.Mvc;

namespace SecondWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        static List<string> employees = new List<string>
        {
            "Sai",
            "Rahul",
            "Priya"
        };

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult Post(string name)
        {
            employees.Add(name);
            return Ok(employees);
        }
    }
}