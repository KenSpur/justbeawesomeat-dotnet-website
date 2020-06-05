using System;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Client.Repositories;
using Application.Client.Repositories.Implementation;
using Application.Client.Services;
using Application.Client.Services.Implementation;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped<INavigationService, NavigationService>();

            builder.Services.AddHttpClient("Application.Server",
                    client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

            builder.Services.AddTransient(sp => sp.GetRequiredService<IHttpClientFactory>()
                .CreateClient("Application.Server"));

            builder.Services.AddTransient<INavMenuDataRepository, NavMenuDataRepository>();
            builder.Services.AddTransient<IIndexPageDataRepository, IndexPageDataRepository>();
            builder.Services.AddTransient<IAboutMePageDataRepository, AboutMePageDataRepository>();
            builder.Services.AddTransient<IResumePageDataRepository, ResumePageDataRepository>();
            builder.Services.AddTransient<IContactPageDataRepository, ContactPageDataRepository>();

            await builder.Build().RunAsync();
        }
    }
}
