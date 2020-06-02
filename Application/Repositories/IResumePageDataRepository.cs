using System.Threading.Tasks;
using Application.Shared.ResumePage;

namespace Application.Client.Repositories
{
    public interface IResumePageDataRepository
    {
        Task<Resume> GetResumeAsync();
    }
}