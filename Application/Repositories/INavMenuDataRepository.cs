using System.Threading.Tasks;
using Application.Shared;

namespace Application.Client.Repositories
{
    public interface INavMenuDataRepository
    {
        Task<Name> GetNameAsync();
    }
}