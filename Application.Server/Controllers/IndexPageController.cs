using Application.Server.Services;
using Application.Shared.IndexPage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;

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
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(IndexPageData), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetData()
            => Ok(await _storageService.GetDataAsync<IndexPageData>());
    }
}
