using Application.Shared.AboutMePage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutMePageController : ControllerBase
    {
        [HttpGet("aboutme")]
        public IActionResult GetAboutMe()
        {
            return Ok(new AboutMe
            {
                Keywords = "Highly driven, Ambitious, Passionate, Self-thought",
                ImageSource = "images/main_photo.png",
                Title = "Technical Consultant .Net",
                Description = "I am a highly driven, ambitious and passionate self-thought Full-stack .Net web/cloud Developer, fascinated by how things work and endlessly excited by current and future possibilities",
                FutureAmbitions = "DevOps Engineering, Cloud solution architecture, Data science, Artificial intelligence, Business Engineering.",
                Info = new Info
                {
                    Age = 31,
                    Residence = "Belgium",
                    Address = "2018 Antwerp",
                    Email = "Spur.Ken@justbeawesomeat.net",
                    Phone = "+32 491 29 67 63",
                    Availability = "Available"
                },
                SocialLinks = new List<SocialLink>
                {
                    new SocialLink
                    {
                        Title = "LinkedIn",
                        Url = "https://www.linkedin.com/in/ken-spur",
                        IconClass = "fa fa-linkedin"
                    },
                    new SocialLink
                    {
                        Title = "FaceBook",
                        Url = "https://www.facebook.com/Ken.Spur.JustBeAwesome",
                        IconClass = "fa fa-facebook"
                    },
                    new SocialLink
                    {
                        Title = "Github",
                        Url = "https://github.com/KenSpur",
                        IconClass = "fa fa-github"
                    },
                    new SocialLink
                    {
                        Title = "Microsoft",
                        Url = "https://docs.microsoft.com/en-us/users/KenSpur",
                        IconClass = "fa fa-windows"
                    },
                    new SocialLink
                    {
                        Title = "Pluralsight",
                        Url = "https://app.pluralsight.com/profile/ken-spur",
                        IconClass = "fa fa-play"
                    },
                    new SocialLink
                    {
                        Title = "Goodreads",
                        Url = "https://www.goodreads.com/user/show/90642412-ken-spur",
                        IconClass = "fa fa-book"
                    }
                },
                Services = new List<Service>
                {
                    new Service
                    {
                        Title = ".Net Consulting",
                        Description = "Be future ready!",
                        IconClass = "pe-7s-icon pe-7s-rocket"
                    },
                    new Service
                    {
                        Title = "Full stack Web Development",
                        Description = "Develop and improve your .Net Web solutions",
                        IconClass = "pe-7s-icon pe-7s-browser"
                    },
                    new Service
                    {
                        Title = "Full stack Cloud Development",
                        Description = "Develop and improve your Azure Cloud solutions",
                        IconClass = "pe-7s-icon pe-7s-cloud"
                    },
                    new Service
                    {
                        Title = "DevOps Engineering",
                        Description = "Develop and improve your Azure DevOps processes",
                        IconClass = "pe-7s-icon pe-7s-loop"
                    },
                },
                Testimonials = new List<Testimonial>
                {
                    new Testimonial
                    {
                        Text = "Place holder text",
                        Author = "FirstName LastName",
                        Firm = "CompanyName"
                    },
                    new Testimonial
                    {
                        Text = "Place holder text",
                        Author = "FirstName LastName",
                        Firm = "CompanyName"
                    }
                },
                FunFacts = new List<FunFact>
                {
                    new FunFact
                    {
                        IconClass = "pe-7s-icon pe-7s-monitor",
                        Title = "Started coding journey since",
                        Value = "2007"
                    },
                    new FunFact
                    {
                        IconClass = "pe-7s-icon pe-7s-coffee",
                        Title = "Coffee Consumed",
                        Value = "∞"
                    },
                    new FunFact
                    {
                        IconClass = "pe-7s-icon pe-7s-next",
                        Title = "Pluralsight courses consumed",
                        Value = "205"
                    },
                    new FunFact
                    {
                        IconClass = "pe-7s-icon pe-7s-notebook",
                        Title = "Books read",
                        Value = "121"
                    }
                }
            });
        }
    }
}
