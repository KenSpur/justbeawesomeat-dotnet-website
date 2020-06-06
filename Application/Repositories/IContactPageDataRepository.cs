using Application.Shared.ContactPage;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface IContactPageDataRepository
    {
        Task<ICollection<Info>> GetInfoAsync();
        Task AddMessageAsync(Message message);
    }
}