using Application.Server.Services;
using Application.Shared.MainPage;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainPageController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public MainPageController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetData()
            => Ok(await _storageService.GetDataAsync<MainPageData>());
    }
}
