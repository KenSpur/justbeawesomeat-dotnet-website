using Application.Shared.AboutMePage;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Application.Client.Repositories.Implementation
{
    public class AboutMePageDataRepository : IAboutMePageDataRepository
    {
        private readonly HttpClient _httpClient;

        public AboutMePageDataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<AboutMe> GetAboutMeAsync()
            => await JsonSerializer.DeserializeAsync<AboutMe>(
                await _httpClient.GetStreamAsync("api/aboutmepage/aboutme"));
    }
}