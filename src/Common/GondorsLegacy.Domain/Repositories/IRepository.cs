using GondorsLegacy.Domain.Entities;
using System.Linq.Expressions;

namespace GondorsLegacy.Domain.Repositories;

public interface IRepository<TEntity, TKey> : IConcurrencyHandler<TEntity>
    where TEntity : Entity<TKey>
{
    IUnitOfWork UnitOfWork { get; }

    IQueryable<TEntity> GetAll();

    Task UpsertAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task InsertAsync(TEntity entity, CancellationToken cancellationToken = default);

    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);

    void Delete(TEntity entity);

    Task<T> FirstOrDefaultAsync<T>(IQueryable<T> query);

    Task<T> SingleOrDefaultAsync<T>(IQueryable<T> query);

    Task<List<T>> ToListAsync<T>(IQueryable<T> query);

    void BulkInsert(IEnumerable<TEntity> entities);

    void BulkInsert(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> predicates);

    void BulkUpdate(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> predicates);

    void BulkMerge(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> idSelector,
        Expression<Func<TEntity, object>> predicates);

    void BulkDelete(IEnumerable<TEntity> entities);
}