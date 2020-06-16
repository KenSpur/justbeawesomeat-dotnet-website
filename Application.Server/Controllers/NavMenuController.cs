using System.Net.Mime;
using Application.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NavMenuController : ControllerBase
    {
        [HttpGet("name")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Name), StatusCodes.Status200OK)]
        public IActionResult GetName()
        {
            return Ok(new Name { FirstName = "Ken", LastName = "Spur" });
        }
    }
}
