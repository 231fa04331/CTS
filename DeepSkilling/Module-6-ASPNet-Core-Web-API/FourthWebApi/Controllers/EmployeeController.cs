using Microsoft.AspNetCore.Mvc;
using FourthWebApi.Models;

namespace FourthWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id=1,
                Name="Sai",
                Salary=50000,
                Permanent=true
            },

            new Employee
            {
                Id=2,
                Name="Rahul",
                Salary=60000,
                Permanent=false
            },

            new Employee
            {
                Id=3,
                Name="Priya",
                Salary=70000,
                Permanent=true
            }
        };

        // GET
        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        // POST
        [HttpPost]
        public ActionResult<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);

            return Ok(employee);
        }

        // PUT
        [HttpPut]
        public ActionResult<Employee> Put([FromBody] Employee employee)
        {
            if(employee.Id<=0)
            {
                return BadRequest("Invalid employee id");
            }

            Employee? emp =
                employees.FirstOrDefault(e=>e.Id==employee.Id);

            if(emp==null)
            {
                return BadRequest("Invalid employee id");
            }

            emp.Name=employee.Name;
            emp.Salary=employee.Salary;
            emp.Permanent=employee.Permanent;

            return Ok(emp);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Employee? emp=
                employees.FirstOrDefault(e=>e.Id==id);

            if(emp==null)
            {
                return BadRequest("Invalid employee id");
            }

            employees.Remove(emp);

            return Ok(employees);
        }
    }
}