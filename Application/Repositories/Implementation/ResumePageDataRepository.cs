using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Application.Shared.ResumePage;

namespace Application.Client.Repositories.Implementation
{
    public class ResumePageDataRepository : IResumePageDataRepository
    {
        private readonly HttpClient _httpClient;

        public ResumePageDataRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Resume> GetResumeAsync()
            => await JsonSerializer.DeserializeAsync<Resume>(
                await _httpClient.GetStreamAsync("api/resumepage/resume"));
    }
}