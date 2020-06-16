using Application.Shared.MainPage;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface IMainPageDataRepository
    {
        Task<MainPageData> GetMainPageDataAsync();
    }
}