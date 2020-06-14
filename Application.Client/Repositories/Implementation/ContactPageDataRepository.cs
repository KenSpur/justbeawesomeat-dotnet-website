using Application.Shared.ContactPage;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Application.Client.Repositories.Implementation
{
    public class ContactPageDataRepository : IContactPageDataRepository
    {
        private readonly HttpClient _httpClient;

        public ContactPageDataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ContactPageData> GetContactPageDataAsync()
            => await _httpClient.GetFromJsonAsync<ContactPageData>("api/contactpage/data");

        public async Task AddMessageAsync(Message message)
            => await _httpClient.PostAsJsonAsync("api/contactpage/message", message);
    }
}