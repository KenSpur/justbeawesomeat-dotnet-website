using Application.Shared.IndexPage;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Application.Client.Repositories.Implementation
{
    public class IndexPageDataRepository : IIndexPageDataRepository
    {
        private readonly HttpClient _httpClient;

        public IndexPageDataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Title> GetTitleAsync()
            => await _httpClient.GetFromJsonAsync<Title>("api/indexpage/title");
    }
}