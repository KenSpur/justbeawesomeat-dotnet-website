using Application.Shared.IndexPage;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexPageController : ControllerBase
    {
        [HttpGet("title")]
        public IActionResult GetTitle()
        {
            return Ok(new Title
            {
                FirstName = "Ken",
                LastName = "Spur",
                Items = new [] { ".Net Consulting", "Full stack Web Development", "Full stack Cloud Development", "DevOps Engineering" }
            });
        }
    }
}
