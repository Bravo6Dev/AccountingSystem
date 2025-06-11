
using System.Linq.Expressions;
using AutoMapper;
using Domain.DTOs;
using Microsoft.EntityFrameworkCore.Query;

namespace Domain.Interfaces.ReposInterface
{
    public interface IBaseRepo<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null!,
            Expression<Func<T, object>>? orderBy = null!,
            Expression<Func<T, object>>? orderByDescending = null!,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null);

        public Task<IEnumerable<TResult>> GetAllAsync<TResult>(IConfigurationProvider configurationProvider,
            Expression<Func<T, bool>>? filter = null!,
            Expression<Func<T, object>>? orderBy = null!,
            Expression<Func<T, object>>? orderByDescending = null!,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null);

        public Task<PaginationResponse<T>> GetAllAsync(int pageNumber, int pageSize,
            Expression<Func<T, bool>>? filter = null!,
            Expression<Func<T, object>>? orderBy = null!,
            Expression<Func<T, object>>? orderByDescending = null!,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null);

        public Task<PaginationResponse<TResult>> GetAllAsync<TResult>(int pageNumber, int pageSize,
            IConfigurationProvider configurationProvider,
            Expression<Func<T, bool>>? filter = null!,
            Expression<Func<T, object>>? orderBy = null!,
            Expression<Func<T, object>>? orderByDescending = null!,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null) where TResult : class;

        public Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null);

        public Task<TResult?> GetFirstOrDefaultAsync<TResult>(IConfigurationProvider configurationProvider,
            Expression<Func<T, bool>> filter,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null);

        public Task<TResult?> GetFirstOrDefaultAsync<TResult>(Expression<Func<T, TResult>> selector,
            Expression<Func<T, bool>> filter,
            bool asNoTracking = false,
            CancellationToken cancellationToken = default,
            Func<IQueryable<T>, IQueryable<T>>? queryModifier = null);

        public Task AddAsync(T entity, CancellationToken cancellationToken = default);

        public Task<int> BulkUpdateAsync(Expression<Func<T, bool>> predicate,
            Expression<Func<SetPropertyCalls<T>, SetPropertyCalls<T>>> updateExpression,
            CancellationToken cancellationToken = default);

        public Task<int> BulkDeleteAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
        public Task<int> DeleteAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);

        public Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default);
    }
}