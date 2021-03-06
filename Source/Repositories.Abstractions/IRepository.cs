﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Repositories.Abstractions
{
    public interface IRepository<TEntity, in TId>
        where TEntity : class
    {
        Task AddAsync(TEntity entity, CancellationToken cancellation = default);

        Task AddRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);

        Task<long> CountAsync(CancellationToken cancellation = default);

        Task<long> CountAsync(IRepositoryQuery<TEntity> query, CancellationToken cancellation = default);

        Task<TEntity> FindByIdAsync(TId id, CancellationToken cancellation = default);

        Task<IEnumerable<TEntity>> QueryAsync(IRepositoryQuery<TEntity> query, CancellationToken cancellation = default);

        Task<TEntity> QuerySingleAsync(IRepositoryQuery<TEntity> query, CancellationToken cancellation = default);

        Task RemoveAsync(TEntity entity, CancellationToken cancellation = default);

        Task RemoveRangeAsync(IEnumerable<TEntity> entities, CancellationToken cancellation = default);
    }
}