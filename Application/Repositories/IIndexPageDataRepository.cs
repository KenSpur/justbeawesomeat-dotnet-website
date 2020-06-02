using System.Threading.Tasks;
using Application.Shared.IndexPage;

namespace Application.Client.Repositories
{
    public interface IIndexPageDataRepository
    {
        Task<Title> GetTitleAsync();
    }
}