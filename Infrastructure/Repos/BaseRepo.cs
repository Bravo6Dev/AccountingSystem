using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.DTOs;
using Domain.Enums;
using Domain.Interfaces.ReposInterface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Infrastructure.Repos
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _context;

        public BaseRepo(AppDbContext context)
        {
            _context = context;
        }

        private IQueryable<T> GetNonDeletedData(IQueryable<T> query)
        {
            var statusProperty = typeof(T).GetProperty("Status");

            if (statusProperty == null || statusProperty.PropertyType != typeof(DataStatus))
                return query;

            var parameter = Expression.Parameter(typeof(T), "entity");
            var propertyAccess = Expression.Property(parameter, statusProperty);

            var deletedValue = Expression.Constant(DataStatus.Deleted);
            var notEqual = Expression.NotEqual(propertyAccess, deletedValue);

            var lambda = Expression.Lambda<Func<T, bool>>(notEqual, parameter);

            return query.Where(lambda);
        }


        private IQueryable<T> SetQuery(IQueryable<T> query, Expression<Func<T, bool>>? filter = null,
        Expression<Func<T, object>>? orderBy = null,
        Expression<Func<T, object>>? orderByDescending = null,
        bool asNoTracking = true,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {

            if (asNoTracking)
                query = query.AsNoTracking();

            if (queryModifier != null)
                query = queryModifier(query);

            if (filter != null)
                query = query.Where(filter);

            if (orderBy != null)
                query = query.OrderBy(orderBy);

            if (orderByDescending != null)
                query = query.OrderByDescending(orderByDescending);

            return query;
        }

        public virtual async Task<int> BulkDeleteAsync(
            Expression<Func<T, bool>> predicate,
            CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>()
                .Where(predicate)
                .ExecuteUpdateAsync(
                    setters => setters
                        .SetProperty(e => EF.Property<DataStatus>(e, "Status"), DataStatus.Deleted),
                    cancellationToken
                );
        }

        public async Task<int> BulkUpdateAsync(Expression<Func<T, bool>> predicate,
        Expression<Func<SetPropertyCalls<T>, SetPropertyCalls<T>>> updateExpression, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().Where(predicate).ExecuteUpdateAsync(updateExpression, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null,
        Expression<Func<T, object>>? orderBy = null,
        Expression<Func<T, object>>? orderByDescending = null,
        bool asNoTracking = true,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {
            IQueryable<T> query = _context.Set<T>();

            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, orderBy, orderByDescending, asNoTracking, queryModifier);

            return await query.ToListAsync(cancellationToken);
        }

        public async Task<IEnumerable<TResult>> GetAllAsync<TResult>(IConfigurationProvider configurationProvider,
        Expression<Func<T, bool>>? filter = null,
        Expression<Func<T, object>>? orderBy = null,
        Expression<Func<T, object>>? orderByDescending = null,
        bool asNoTracking = true,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {
            IQueryable<T> query = _context.Set<T>();

            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, orderBy, orderByDescending, asNoTracking, queryModifier);
            return await query
                .ProjectTo<TResult>(configurationProvider)
                .ToListAsync(cancellationToken);
        }

        public async Task<PaginationResponse<T>> GetAllAsync(int pageNumber, int pageSize,
        Expression<Func<T, bool>>? filter = null,
        Expression<Func<T, object>>? orderBy = null,
        Expression<Func<T, object>>? orderByDescending = null,
        bool asNoTracking = false,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {
            IQueryable<T> query = _context.Set<T>();

            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, orderBy, orderByDescending, asNoTracking, queryModifier);

            int totalCount = await query.CountAsync(cancellationToken);

            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            List<T> result = await query.ToListAsync(cancellationToken);

            return new PaginationResponse<T>(pageNumber, pageSize, totalCount, result);
        }

        public async Task<PaginationResponse<TResult>> GetAllAsync<TResult>(int pageNumber, int pageSize,
        IConfigurationProvider configurationProvider,
        Expression<Func<T, bool>>? filter = null,
        Expression<Func<T, object>>? orderBy = null,
        Expression<Func<T, object>>? orderByDescending = null,
        bool asNoTracking = false,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null) where TResult : class
        {
            IQueryable<T> query = _context.Set<T>();

            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, orderBy, orderByDescending, asNoTracking, queryModifier);

            int totalCount = await query.CountAsync(cancellationToken);

            query = query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            IEnumerable<TResult> result = await query
                .ProjectTo<TResult>(configurationProvider)
                .ToListAsync(cancellationToken);

            return new PaginationResponse<TResult>(pageNumber, pageSize, totalCount, result);
        }

        public Task<T?> GetFirstOrDefaultAsync(Expression<Func<T, bool>> filter,
        bool asNoTracking = false,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {
            IQueryable<T> query = _context.Set<T>();
            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, null, null, asNoTracking, queryModifier);
            return query.FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<TResult?> GetFirstOrDefaultAsync<TResult>(IConfigurationProvider configurationProvider,
        Expression<Func<T, bool>> filter,
        bool asNoTracking = false,
        CancellationToken cancellationToken = default,
        Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {
            IQueryable<T> query = _context.Set<T>();
            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, null, null, asNoTracking, queryModifier);
            return await query
                .ProjectTo<TResult>(configurationProvider)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<bool> IsExistAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().AnyAsync(predicate, cancellationToken);
        }

        public virtual async Task AddAsync(T entity, CancellationToken cancellationToken = default)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public Task<TResult?> GetFirstOrDefaultAsync<TResult>(Expression<Func<T, TResult>> selector, Expression<Func<T, bool>> filter, bool asNoTracking = false, CancellationToken cancellationToken = default, Func<IQueryable<T>, IQueryable<T>>? queryModifier = null)
        {
            IQueryable<T> query = _context.Set<T>();
            query = GetNonDeletedData(query);
            query = SetQuery(query, filter, null, null, asNoTracking, queryModifier);
            return query.Select(selector).FirstOrDefaultAsync(cancellationToken);
        }

        public virtual async Task<int> DeleteAsync(Expression<Func<T, bool>> predicate, CancellationToken cancellationToken = default)
        {
            return await _context.Set<T>().Where(predicate).ExecuteDeleteAsync(cancellationToken);
        }
    }

}