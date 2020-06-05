using System.Collections.Generic;
using System.Threading.Tasks;
using Application.Shared.ContactPage;

namespace Application.Client.Repositories
{
    public interface IContactPageDataRepository
    {
        Task<ICollection<Info>> GetInfoAsync();
        Task AddMessageAsync(Message message);
    }
}