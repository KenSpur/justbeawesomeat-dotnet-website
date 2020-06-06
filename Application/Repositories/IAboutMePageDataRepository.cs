using Application.Shared.AboutMePage;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface IAboutMePageDataRepository
    {
        Task<AboutMe> GetAboutMeAsync();
    }
}