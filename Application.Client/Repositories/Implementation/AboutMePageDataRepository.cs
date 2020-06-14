using Application.Shared.AboutMePage;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task<AboutMePageData> GetAboutMePageDataAsync()
            => await _httpClient.GetFromJsonAsync<AboutMePageData>("api/aboutmepage/aboutme");
    }
}