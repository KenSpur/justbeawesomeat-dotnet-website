using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Application.Shared;

namespace Application.Client.Repositories.Implementation
{
    public class NavMenuDataRepository : INavMenuDataRepository
    {
        private readonly HttpClient _httpClient;

        public NavMenuDataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Name> GetNameAsync()
            => await JsonSerializer.DeserializeAsync<Name>(
                await _httpClient.GetStreamAsync("api/navmenu/name"));
    }
}