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
            return Ok(new IndexPageData
            {
                Title = new Title
                {
                    FirstName = "Ken",
                    LastName = "Spur",
                    Items = new[] { ".Net Consultant", "Full stack Web Developer", "Full stack Cloud Developer", "DevOps Engineer" }
                }
            });
        }
    }
}
