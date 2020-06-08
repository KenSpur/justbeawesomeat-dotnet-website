using Application.Shared.ResumePage;
using System.Threading.Tasks;

namespace Application.Client.Repositories
{
    public interface IResumePageDataRepository
    {
        Task<Resume> GetResumeAsync();
    }
}