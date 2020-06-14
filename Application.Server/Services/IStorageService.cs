using System.Threading.Tasks;
using Application.Shared;

namespace Application.Server.Services
{
    public interface IStorageService
    {
        Task<T> GetDataAsync<T>() where T : IPageData;
    }
}