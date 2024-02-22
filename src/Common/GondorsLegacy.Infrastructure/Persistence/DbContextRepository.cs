using System.Linq.Expressions;
using EntityFrameworkCore.SqlServer.SimpleBulks.BulkDelete;
using EntityFrameworkCore.SqlServer.SimpleBulks.BulkInsert;
using EntityFrameworkCore.SqlServer.SimpleBulks.BulkMerge;
using EntityFrameworkCore.SqlServer.SimpleBulks.BulkUpdate;
using GondorsLegacy.CrossCuttingCorners.DateTimes;
using GondorsLegacy.Domain.Entities;
using GondorsLegacy.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GondorsLegacy.Infrastructure.Persistence;

public class DbContextRepository<TDbContext, TEntity, TKey> : IRepository<TEntity, TKey>
    where TEntity : Entity<TKey>
    where TDbContext : DbContext, IUnitOfWork
{
    private readonly TDbContext _dbContext;
    private readonly IDateTimeProvider _dateTimeProvider;

    protected DbSet<TEntity> DbSet => _dbContext.Set<TEntity>();

    public IUnitOfWork UnitOfWork => _dbContext;

    public DbContextRepository(TDbContext dbContext, IDateTimeProvider dateTimeProvider)
    {
        _dbContext = dbContext;
        _dateTimeProvider = dateTimeProvider;
    }

    public IQueryable<TEntity> GetAll()
    {
        return DbSet;
    }

    public async Task UpsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        if (entity.Id.Equals(default(TKey)))
        {
            await InsertAsync(entity, cancellationToken);
        }
        else
        {
            await UpdateAsync(entity, cancellationToken);
        }
    }

    public async Task InsertAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        entity.CreatedDateTime = _dateTimeProvider.OffsetNow;
        await DbSet.AddAsync(entity, cancellationToken);
    }

    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        entity.UpdatedDateTime = _dateTimeProvider.OffsetNow;
        DbSet.Update(entity);
        await Task.CompletedTask;
    }

    public void Delete(TEntity entity)
    {
        DbSet.Remove(entity);
    }

    public async Task<T> FirstOrDefaultAsync<T>(IQueryable<T> query)
    {
        return await query.FirstOrDefaultAsync();
    }


    public async Task<T> SingleOrDefaultAsync<T>(IQueryable<T> query)
    {
        return await query.SingleOrDefaultAsync();
    }

    public async Task<List<T>> ToListAsync<T>(IQueryable<T> query)
    {
        return await query.ToListAsync();
    }


    public void BulkInsert(IEnumerable<TEntity> entities)
    {
        _dbContext.BulkInsert(entities);
    }


    public void BulkInsert(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> predicates)
    {
        _dbContext.BulkInsert(entities, predicates);
    }


    public void BulkUpdate(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> predicates)
    {
        _dbContext.BulkUpdate(entities, predicates);
    }

    public void BulkMerge(IEnumerable<TEntity> entities, Expression<Func<TEntity, object>> idSelector,
        Expression<Func<TEntity, object>> predicates)
    {
        _dbContext.BulkMerge(entities, idSelector, predicates, predicates);
    }

    public void BulkDelete(IEnumerable<TEntity> entities)
    {
        _dbContext.BulkDelete(entities);
    }

    public void SetRowVersion(TEntity entity, byte[] version)
    {
        _dbContext.Entry(entity).OriginalValues[nameof(entity.RowVersion)] = version;
    }

    public bool IsDbUpdateConcurrencyException(Exception ex)
    {
        return ex is DbUpdateConcurrencyException;
    }
}