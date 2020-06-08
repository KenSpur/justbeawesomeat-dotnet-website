using Application.Shared;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface INavMenuDataRepository
    {
        Task<Name> GetNameAsync();
    }
}