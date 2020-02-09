using System;
using System.Linq.Expressions;

namespace Repositories.Abstractions
{
    public interface IRepositoryQuery<TEntity>
    {
        Expression<Func<TEntity, bool>> GetQuery();
    }
}