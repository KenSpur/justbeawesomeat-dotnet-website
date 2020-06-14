using Application.Shared.MainPage;
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
            return Ok(new MainPageData
            {
                NavMenuDetails = new NavMenuDetails
                {
                    ImageSource = "images/jba-monkey.jpg",
                    FirstName = "Ken",
                    LastName = "Spur",
                }
            });
        }
    }
}
