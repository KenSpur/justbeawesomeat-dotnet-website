using System.Net.Mime;
using Application.Shared.IndexPage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexPageController : ControllerBase
    {
        [HttpGet("title")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(Title), StatusCodes.Status200OK)]
        public IActionResult GetTitle()
        {
            return Ok(new Title
            {
                FirstName = "Ken",
                LastName = "Spur",
                Items = new[] { ".Net Consultant", "Full stack Web Developer", "Full stack Cloud Developer", "DevOps Engineer" }
            });
        }
    }
}
