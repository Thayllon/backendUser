using System.Threading.Tasks;

namespace Backend.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
