using System;
using System.Linq;
using System.Linq.Expressions;

namespace Repositories.Abstractions
{
    public interface IRepositoryQuery<TEntity>
    {
        Expression<Func<TEntity, bool>> GetQuery();

        IQueryable<TEntity> Hydrate(IQueryable<TEntity> entity);
    }
}