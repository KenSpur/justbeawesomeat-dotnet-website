using Application.Server.Options;
using Application.Shared.ContactPage;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactPageController : ControllerBase
    {
        private readonly SendGridOptions _options;

        public ContactPageController(IOptions<SendGridOptions> options)
        {
            _options = options.Value;
        }

        [HttpGet("info")]
        public IActionResult GetInfo()
        {
            return Ok(new List<Info>
            {
                new Info
                {
                    IconClass = "pe-7s-icon pe-7s-map-marker",
                    Text = "2018 Antwerp"
                },
                new Info
                {
                    IconClass = "pe-7s-icon pe-7s-mail",
                    Text = "Spur.ken@justbeawesomeat.net"
                },
                new Info
                {
                    IconClass = "pe-7s-icon pe-7s-call",
                    Text = "+32 491 29 67 63"
                },
                new Info
                {
                    IconClass = "pe-7s-icon pe-7s-check",
                    Text = "Freelance Available"
                }
            });
        }

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
