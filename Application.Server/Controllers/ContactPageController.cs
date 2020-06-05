using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Shared.ContactPage;
using Microsoft.AspNetCore.Mvc;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactPageController : ControllerBase
    {
        public ContactPageController()
        {

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
            //var msg =  new SendGridMessage();

            //msg.SetFrom(new EmailAddress(message.Email, message.Name));

            //msg.AddTo(new EmailAddress("Spur.ken@gmail.com", "Ken Spur"));

            //msg.SetSubject($"{message.Name} - Jba@.net");
            //msg.AddContent(MimeType.Text, message.Text);

            //await new SendGridClient("").SendEmailAsync(msg);

            return Ok();
        }
    }
}
