using Application.Shared.AboutMePage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Server.Services;

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
