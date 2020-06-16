using Application.Server.Services;
using Application.Shared.AboutMePage;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetDataAsync()
            => Ok(await _storageService.GetDataAsync<AboutMePageData>());
    }
}
