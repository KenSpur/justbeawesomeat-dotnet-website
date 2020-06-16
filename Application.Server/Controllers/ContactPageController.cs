﻿using Application.Server.Options;
using Application.Shared.ContactPage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SendGrid;
using System.Threading.Tasks;
using Application.Server.Services;
using SendGrid.Helpers.Mail;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactPageController : ControllerBase
    {
        private readonly IStorageService _storageService;
        private readonly SendGridOptions _options;

        public ContactPageController(IOptions<SendGridOptions> options, IStorageService storageService)
        {
            _storageService = storageService;
            _options = options.Value;
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetData()
            => Ok(await _storageService.GetDataAsync<ContactPageData>());

        [HttpPost("message")]
        public async Task<IActionResult> PostMessage([FromBody] Message message)
        {
            var msg = new SendGridMessage();

            msg.SetFrom(new EmailAddress(message.Email, message.Name));

            msg.AddTo(new EmailAddress("Spur.ken@justbeawesomeat.net", "Ken Spur"));

            msg.SetSubject($"{message.Name} - Contact Form");
            msg.AddContent(MimeType.Text, message.Text);

            await new SendGridClient(_options.ApiKey).SendEmailAsync(msg);

            return Ok();
        }
    }
}
