using Application.Shared.ResumePage;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

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
            => await _httpClient.GetFromJsonAsync<Resume>("api/resumepage/resume");
    }
}