using Application.Shared.MainPage;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainPageController : ControllerBase
    {
        [HttpGet("data")]
        public IActionResult GetData()
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
