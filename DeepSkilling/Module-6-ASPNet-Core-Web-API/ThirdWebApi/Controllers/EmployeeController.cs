using Microsoft.AspNetCore.Mvc;
using ThirdWebApi.Models;

namespace ThirdWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private List<Employee> employees;

        public EmployeeController()
        {
            employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Sai",
                    Salary = 50000,
                    Permanent = true,
                    DateOfBirth = new DateTime(2002,5,20),

                    Department = new Department
                    {
                        Id = 101,
                        Name = "IT"
                    },

                    Skills = new List<Skill>
                    {
                        new Skill{Id=1,Name="C#"},
                        new Skill{Id=2,Name="SQL"}
                    }
                },

                new Employee
                {
                    Id = 2,
                    Name = "Rahul",
                    Salary = 60000,
                    Permanent = false,
                    DateOfBirth = new DateTime(2001,10,15),

                    Department = new Department
                    {
                        Id = 102,
                        Name = "HR"
                    },

                    Skills = new List<Skill>
                    {
                        new Skill{Id=3,Name="Java"}
                    }
                }
            };
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employees);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Employee employee)
        {
            return Ok(employee);
        }
    }
}