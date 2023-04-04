using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("all")]
        public IActionResult GetUsers()
        {
            return Ok();
        }

        [HttpGet("details/{id}")]
        public IActionResult GetUserDetails()
        {
            return Ok();
        }
    }
}
