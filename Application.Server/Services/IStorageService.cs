using Application.Shared;
using System.Threading.Tasks;

namespace Application.Server.Services
{
    public interface IStorageService
    {
        Task<T> GetDataAsync<T>() where T : IPageData;
    }
}