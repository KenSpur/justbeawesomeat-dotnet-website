using Application.Shared.IndexPage;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface IIndexPageDataRepository
    {
        Task<IndexPageData> GetIndexPageDataAsync();
    }
}