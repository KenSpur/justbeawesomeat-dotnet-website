using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Application.Shared.MainPage;

namespace Application.Client.Repositories.Implementation
{
    public class NavMenuDataRepository : IMainPageDataRepository
    {
        private readonly HttpClient _httpClient;

        public NavMenuDataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<MainPageData> GetMainPageDataAsync()
            => await _httpClient.GetFromJsonAsync<MainPageData>("api/mainpage/data");
    }
}