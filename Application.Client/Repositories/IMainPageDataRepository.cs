using System.Threading.Tasks;
using Application.Shared.MainPage;

namespace Application.Client.Repositories
{
    public interface IMainPageDataRepository
    {
        Task<MainPageData> GetMainPageDataAsync();
    }
}