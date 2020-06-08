using Application.Shared.ResumePage;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Application.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResumePageController : ControllerBase
    {
        [HttpGet("resume")]
        public IActionResult GetResume()
        {
            return Ok(new Resume
            {
                YearsOfExperience = 3,
                Certifications = new List<Certification>
                {
                    new Certification
                    {
                        Period = "Sep - 2014",
                        Title = "Microsoft Specialist",
                        Authority = "Microsoft",
                        Description = "Microsoft Specialist: Programming in C#"
                    },
                    new Certification
                    {
                        Period = "Sep - 2014",
                        Title = "Microsoft Certified Professional",
                        Authority = "Microsoft",
                        Description = "Microsoft Certified Professional"
                    }
                },
                Experiences = new List<Experience>
                {
                    new Experience
                    {
                        Period = "Apr 2020 - Current",
                        Client = "Freelance (Self Employed)",
                        Title = "Technical Consultant .Net",
                    },
                    new Experience
                    {
                        Period = "May 2020 - June 2020",
                        Client = "Project (Self Employed)",
                        Title = ".Net Developer",
                        Description = "Design and develop resume website.",
                        Tasks = new List<string>
                        {
                            "Full Stack development"
                        },
                        Tags = new List<string>
                        {
                            "HTML", "CSS", "Bootstrap", "JavaScript", "jQuery", "Blazor Wasm",
                            "C#", ".Net Core", "Git", "Azure DevOps","Azure", "Visual Studio 2019"
                        }
                    },
                    new Experience
                    {
                        Period = "Jan 2020 - Mar 2020",
                        Client = "AllPhi (Internal)",
                        Title = "System Administrator",
                        Description = "Help improve internally used IT infrastructure.",
                        Tasks = new List<string>
                        {
                            "Setup CI/CD pipelines for internal projects",
                            "Manage Azure cloud & Microsoft 365 Admin Environment"
                        },
                        Tags = new List<string>
                        {
                            "Azure portal", "Azure DevOps", "Microsoft 365 Admin Environment"
                        }
                    },
                    new Experience
                    {
                        Period = "Dec 2019 - Mar 2020",
                        Client = "AllPhi (Client 3)",
                        Sector = "Health Care",
                        Title = "Technical consultant .Net",
                        Description = "Build data translation solution for company merger with external offices.",
                        Tasks = new List<string>
                        {
                            "Build solution that translates data dumps to domain events",
                            "Setup CI/CD pipelines",
                            "Setup Unit, Integration, and End to end tests",

                        },
                        Tags = new List<string>
                        {
                            "C#", ".Net Core", "T-SQL", "EF Core", "NuGet", "Topshelf", "Azure DevOps",
                            "Git", "YAML", "PowerShell", "SFTP", "RabbitMQ", "MS Test", "Visual Studio 2019",
                            "VS Code", "Agile", "Scrum"
                        }
                    },
                    new Experience
                    {
                        Period = "Nov 2019 - Dec 2019",
                        Client = "AllPhi (Client 3)",
                        Sector = "Health Care",
                        Title = "Technical consultant .Net",
                        Description = "Build documentation solution POC for internally used framework and micro services.",
                        Tasks = new List<string>
                        {
                            "Build small POC service that hosts DocFX documentation",
                            "Setup DocFX POC implementation for internally used framework and micro services",
                            "Setup CI/CD pipelines",
                            "Document solution and use"
                        },
                        Tags = new List<string>
                        {
                            "C#", ".Net Core", "DocFX", "Azure App Services", "Azure AD",
                            "OpenID Connect", "Azure Functions", "Azure Storage", "Azure DevOps",
                            "TFS", "PowerShell", "YAML", "Markdown", "Visual Studio 2019", "VS Code"
                        }
                    },
                    new Experience
                    {
                        Period = "Jul 2019 - Nov 2019",
                        Client = "AllPhi (Client 3)",
                        Sector = "Health Care",
                        Title = "Technical consultant .Net",
                        Description = "Analyze and migrate internally used framework and micro services from .net core 1.x-preview/Net452/Portable to .net core 2.1 LTS/Net461/Net Standard.",
                        Tasks = new List<string>
                        {
                            "Analyze and migrate framework used to setup new micro services (120+ projects)",
                            "Analyze and migrate micro services using internal framework",
                            "Analyze and migrate tools used to setup and aid micro service development",
                            "Analyze and migrate CI/CD pipelines",
                            "Analyze requirements to migrate last Net461 dependencies to net Standard"
                        },
                        Tags = new List<string>
                        {
                            "C#", ".Net Core 1.x-Preview/2.1 LTS", ".Net Framework 4.5.2/4.6.1", "EF", "EF Core",
                            "MSBuild", "VSIX", "XML", "NuGet", "Topshelf", "RabbitMQ", "MS Test", "Azure DevOps",
                            "TFS", "Visual Studio 2015-2019"
                        }
                    },
                    new Experience
                    {
                        Period = "Apr 2019 – Jul 2019",
                        Client = "AllPhi (Client 3)",
                        Sector = "Health Care",
                        Title = "Technical consultant .Net",
                        Description = "Reimplement route planner API to solve dependency issue, Develop, test, and maintain internally used micro services and applications.",
                        Tasks = new List<string>
                        {
                            "Analyze and implement Google Maps API solution",
                            "Backend development in micro service architecture",
                            "Setup Unit and Integration tests",
                        },
                        Tags = new List<string>
                        {
                            "C#", ".Net Core 1.x-Preview", ".Net Framework 4.5.2", "EF", "NHibernate",
                            "NuGet", "Hyper-V", "Topshelf", "RabbitMQ", "MS Test", "Azure DevOps", "TFS",
                            "Google APIs", "Visual Studio 2015", "Micro service Architecture", "DDD", "CQRS",
                            "Agile", "Scrum"
                        }
                    },
                    new Experience
                    {
                        Period = "Feb 2019 - Apr 2019",
                        Client = "AllPhi (Client 2)",
                        Sector = "Non-profit",
                        Title = "Technical consultant .Net",
                        Description = "Improve maintainability, security, and implement new features for mobile application.",
                        Tasks = new List<string>
                        {
                            "Refactor mobile application and apply Enterprise application patterns",
                            "Refactor Admin portal and backend services and apply Enterprise application patterns",
                            "Migrate portable libraries to .net Standard",
                            "Migrate .Net Framework services to .Net Core",
                            "Refactor security, implement Identity Service and apply OIDC security standards",
                            "Implement new features",
                            "Setup CI/CD pipelines",
                            "Setup Azure environment"
                        },
                        Tags = new List<string>
                        {
                            "Xamarin", "XAML", "C#", ".Net Framework", ".Net Core", "HTML",
                            "CSS", "JavaScript", "Razor", "EF", "EF Core", "T-SQL", "NuGet",
                            "Identity Server", "OpenID Connect", "Oath", "Azure Storage",
                            "Azure Functions", "Azure App Services", "Azure container registry",
                            "Docker", "Azure DevOps", "Git", "YAML", "PowerShell", "App Center",
                            "Visual Studio 2017", "VS Code", "Micro service Architecture", "DDD",
                            "Agile", "Scrum"
                        }
                    },
                    new Experience
                    {
                        Period = "Dec 2018 - Feb 2019",
                        Client = "AllPhi (Internal)",
                        Title = "Technical consultant .Net",
                        Description = "Internal rebuild of internally used CRM/ERP application to micro service architecture approach.",
                        Tasks = new List<string>
                        {
                            "Setup Identity Service and apply OIDC security standards",
                            "Help Analyze and develop micro services",
                        },
                        Tags = new List<string>
                        {
                            "C#", ".Net Framework", ".Net Core", "HTML", "CSS", "JavaScript",
                            "Razor", "EF", "EF Core", "T-SQL", "NuGet", "Identity Server",
                            "OpenID Connect", "Oath", "Azure AD", "Azure Service Fabric",
                            "Azure Service Bus", "Azure DevOps", "Git", "Visual studio 2017",
                            "Micro service Architecture", "DDD", "CQRS", "Agile", "Scrum"
                        }
                    },
                    new Experience
                    {
                        Period = "Aug 2018 - Dec 2018",
                        Client = "AllPhi (Client 1)",
                        Sector = "BIM",
                        Title = "Technical consultant .Net",
                        Description = "Help hit client’s deadline setting up new BIM sector application POC.",
                        Tasks = new List<string>
                        {
                            "Backend Web API development in micro service architecture",
                            "Setup Unit and Integration tests",
                        },
                        Tags = new List<string>
                        {
                            "C#", ".Net Core", "EF Core", "Swagger", "XUnit", "Azure DevOps",
                            "Git", "Docker", "AWS", "Visual studio 2017", "Micro service Architecture",
                            "DDD", "Agile", "Scrum"
                        }
                    },
                    new Experience
                    {
                        Period = "Mar 2017 - Aug 2018",
                        Client = "Project (Self Employed)",
                        Sector = "BIM",
                        Title = ".Net Developer",
                        Description = "Design and develop Direct Sales ERP System, automate current employer’s direct sales administration, and provide valuable Kpi’s and insights for Direct sales consultants.",
                        Tasks = new List<string>
                        {
                            "Full Stack development",
                        },
                        Tags = new List<string>
                        {
                            "HTML", "CSS", "Bootstrap", "JavaScript", "jQuery", "Ajax", "Razor",
                            "TypeScript", "Angular", "C#", ".Net Framework", ".Net Core", "Git", "VSTS",
                            "Azure", "EF", "EF Core", "T-SQL", "Visual Studio", "MVC", "MVVM", "DDD"
                        }
                    }
                },
                SkillsCollection = new List<Skills>
                {
                    new Skills
                    {
                        Title = "Primary Skills",
                        Collection = new List<Skill>
                        {
                            new Skill
                            {
                                Title = "C#",
                                Percentage = 90
                            },
                            new Skill
                            {
                                Title = ".Net Core",
                                Percentage = 90
                            },
                            new Skill
                            {
                                Title = ".Net Framework",
                                Percentage = 85
                            },
                            new Skill
                            {
                                Title = "Asp.Net",
                                Percentage = 90
                            },
                            new Skill
                            {
                                Title = "Blazor",
                                Percentage = 80
                            },
                            new Skill
                            {
                                Title = "T-SQL",
                                Percentage = 75
                            },
                            new Skill
                            {
                                Title = "PowerShell",
                                Percentage = 60
                            },
                            new Skill
                            {
                                Title = "Git",
                                Percentage = 75
                            },
                            new Skill
                            {
                                Title = "Azure PaaS",
                                Percentage = 80
                            },
                            new Skill
                            {
                                Title = "Azure IaaS",
                                Percentage = 50
                            },
                            new Skill
                            {
                                Title = "Azure DevOps",
                                Percentage = 80
                            }
                        }
                    },
                    new Skills
                    {
                        Title = "Other Skills",
                        Collection = new List<Skill>
                        {
                            new Skill
                            {
                                Title = "HTML",
                                Percentage = 75
                            },
                            new Skill
                            {
                                Title = "CSS",
                                Percentage = 60
                            },
                            new Skill
                            {
                                Title = "JavaScript",
                                Percentage = 70
                            },
                            new Skill
                            {
                                Title = "TypeScript",
                                Percentage = 70
                            },
                            new Skill
                            {
                                Title = "jQuery",
                                Percentage = 70
                            },
                            new Skill
                            {
                                Title = "Angular",
                                Percentage = 65
                            },
                            new Skill
                            {
                                Title = "Xamarin Forms",
                                Percentage = 75
                            }
                        }
                    },
                },
                IndustryKnowledge = new List<string>
                {
                    "Cloud-native architecture", "Web architecture", "Design patterns", "Enterprise application patterns",
                    "Clean coding principles", "Test driven development", "Domain driven design", "DevOps practices",
                    "Lean principles", "Container Orchestration", "Agile project management"
                }
            });
        }
    }
}
