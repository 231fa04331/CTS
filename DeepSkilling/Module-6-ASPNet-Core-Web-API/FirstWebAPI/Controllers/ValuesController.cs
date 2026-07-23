using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("GET Method");
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("POST Method");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("PUT Method");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("DELETE Method");
        }
    }
}