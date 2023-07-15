using Microsoft.AspNetCore.Mvc;
using aspnet_docker.Models;
using aspnet_docker.Data;

namespace aspnet_docker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserContext userContext;
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<object>> GetUserById(int id)
        {
            if(userContext == null)
            {
                return NotFound();
            }

            var user = userContext.Users.Where(u => u.Id == id); 
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();

        }



    }
}