using System.Collections.Generic;
using System.Threading.Tasks;

namespace IyibankAppService.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        int Commit();

        Task<int> CommitAsync();

        IList<T> Sql<T>(string sql);

        T ExecuteScalar<T>(string sql);
    }
}
