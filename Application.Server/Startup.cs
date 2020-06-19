using Application.Server.Defaults;
using Application.Server.Options;
using Application.Server.Services;
using Application.Server.Services.Implementations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Application.Server
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.Configure<SendGridOptions>(options => Configuration
                .GetSection(ApplicationDefaults.SendGrindOptions).Bind(options));
            services.Configure<AzureStorageOptions>(options => Configuration
                .GetSection(ApplicationDefaults.AzureStorageOptions).Bind(options));
            services.AddTransient<IStorageService, StorageService>();
            services.AddApplicationInsightsTelemetry(options => Configuration
                .GetSection(ApplicationDefaults.AppInsightsOptions).Bind(options));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseBlazorFrameworkFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
