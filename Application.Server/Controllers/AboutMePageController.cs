using Application.Server.Services;
using Application.Shared.AboutMePage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMePageController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public AboutMePageController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("data")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(AboutMePageData), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetDataAsync()
            => Ok(await _storageService.GetDataAsync<AboutMePageData>());
    }
}
