using Application.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavMenuController : ControllerBase
    {
        [HttpGet("name")]
        public IActionResult GetName()
        {
            return Ok(new Name { FirstName = "Ken", LastName = "Spur"});
        }
    }
}
