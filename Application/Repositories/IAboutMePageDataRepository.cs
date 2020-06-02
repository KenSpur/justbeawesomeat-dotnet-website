using System.Threading.Tasks;
using Application.Shared.AboutMePage;

namespace Application.Client.Repositories
{
    public interface IAboutMePageDataRepository
    {
        Task<AboutMe> GetAboutMeAsync();
    }
}