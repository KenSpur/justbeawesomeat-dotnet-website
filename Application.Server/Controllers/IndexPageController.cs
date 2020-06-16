using System.Threading.Tasks;
using Application.Server.Services;
using Application.Shared.IndexPage;
using Microsoft.AspNetCore.Mvc;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndexPageController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public IndexPageController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetData()
            => Ok(await _storageService.GetDataAsync<IndexPageData>());
    }
}
