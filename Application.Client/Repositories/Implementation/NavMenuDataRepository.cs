using Application.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

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
            => await _httpClient.GetFromJsonAsync<Name>("api/navmenu/name");
    }
}