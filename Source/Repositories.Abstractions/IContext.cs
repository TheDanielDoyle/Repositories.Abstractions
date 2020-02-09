using System.Threading;
using System.Threading.Tasks;

namespace Repositories.Abstractions
{
    public interface IContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellation = default);
    }
}
