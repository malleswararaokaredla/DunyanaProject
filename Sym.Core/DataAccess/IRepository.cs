﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sym.Core.DataAccess
{
    public interface IRepository<TEntity> : IQueryable<TEntity>
        where TEntity : class
    {
        /// <summary>
        /// Filters a sequence of values based on a predicate. This method is no-tracking query.
        /// </summary>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>An <see cref="IQueryable{T}"/> that contains elements that satisfy the condition specified by predicate.</returns>
        /// <remarks>This method is no-tracking query.</remarks>
        //IQueryable<TEntity> Query(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Filters a sequence of values based on a predicate. This method will change tracking by context.
        /// </summary>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <returns>An <see cref="IQueryable{T}"/> that contains elements that satisfy the condition specified by predicate.</returns>
        /// <remarks>This method will change tracking by context.</remarks>
        //IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

       

        /// <summary>
        /// Finds an entity with the given primary key values. If found, is attached to the context and returned. If no entity is found, then null is returned.
        /// </summary>
        /// <param name="keyValues">The values of the primary key for the entity to be found.</param>
        /// <returns>A <see cref="Task{TResult}"/> that represents the asynchronous find operation. The task result contains the found entity or null.</returns>
        Task<TEntity> FindAsync(params object[] keyValues);

        /// <summary>
        /// Inserts a new entity asynchronously.
        /// </summary>
        /// <param name="entity">The entity to insert.</param>
        /// <returns>A <see cref="Task{TResult}"/> that represents the asynchronous insert operation.</returns>
        Task InsertAsync(TEntity entity);

        /// <summary>
        /// Inserts a range of entities asynchronously.
        /// </summary>
        /// <param name="entities">The entities to insert.</param>
        /// <returns>Task.</returns>
        Task InsertAsync(params TEntity[] entities);

        /// <summary>
        /// Inserts a range of entities asynchronously.
        /// </summary>
        /// <param name="entities">The entities to insert.</param>
        /// <returns>A <see cref="Task{TResult}"/> that represents the asynchronous insert operation.</returns>
        Task InsertAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        void Update(TEntity entity);
        /// <summary>
        /// Asynchrously Updates the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        Task<int> UpdateAsync(TEntity entity);

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Update(params TEntity[] entities);

        /// <summary>
        /// Updates the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Update(IEnumerable<TEntity> entities);

        /// <summary>
        /// Deletes the entity by the specified primary key.
        /// </summary>
        /// <param name="id">The primary key value.</param>
        void Delete(object id);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(TEntity entity);

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Delete(params TEntity[] entities);

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        void Delete(IEnumerable<TEntity> entities);
        
        /// <summary>
        /// Sets entity state to unchanged to persist entity modifications to database
        /// </summary>
        /// <param name="entity">The entity.</param>
        void SetUnchanged(TEntity entity);
    }
}
