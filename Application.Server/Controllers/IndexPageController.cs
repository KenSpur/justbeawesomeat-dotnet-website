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
                Items = new [] { "Full Stack .Net Web/Cloud Developer", "C# Specialist", "DevOps engineer" }
            });
        }
    }
}
