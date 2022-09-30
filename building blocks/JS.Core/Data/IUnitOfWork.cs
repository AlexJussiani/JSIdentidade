using System.Threading.Tasks;

namespace JS.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}