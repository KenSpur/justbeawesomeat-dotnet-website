using Application.Shared.ContactPage;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface IContactPageDataRepository
    {
        Task<ContactPageData> GetContactPageDataAsync();
        Task AddMessageAsync(Message message);
    }
}