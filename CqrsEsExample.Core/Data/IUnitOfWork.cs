using System.Threading.Tasks;

namespace CqrsEsExample.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
