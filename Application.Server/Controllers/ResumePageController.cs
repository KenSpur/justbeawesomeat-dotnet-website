using Application.Server.Services;
using Application.Shared.ResumePage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Threading.Tasks;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumePageController : ControllerBase
    {
        private readonly IStorageService _storageService;

        public ResumePageController(IStorageService storageService)
        {
            _storageService = storageService;
        }

        [HttpGet("data")]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ResumePageData), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetData()
            => Ok(await _storageService.GetDataAsync<ResumePageData>());
    }
}
