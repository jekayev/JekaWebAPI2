/*IRepository.cs
DESKTOP-EUQ638R\YMYKHAILOV
*/

namespace JekaWebAPI2.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    /// <summary>
    /// Defines the <see cref="IRepository{T}" />
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// The Get
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        /// <returns>The <see cref="T"/></returns>
        T Get(int id);

        /// <summary>
        /// The GetFirstOrDefault
        /// </summary>
        /// <param name="filter">The filter<see cref="Expression{Func{T, bool}}"/></param>
        /// <param name="includeProperties">The includeProperties<see cref="string"/></param>
        /// <returns>The <see cref="T"/></returns>
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        /// <summary>
        /// The GetAll
        /// </summary>
        /// <param name="filter">The filter<see cref="Expression{Func{T, bool}}"/></param>
        /// <param name="orderBy">The orderBy<see cref="Func{IQueryable{T}, IOrderedQueryable{T}}"/></param>
        /// <param name="includeProperties">The includeProperties<see cref="string"/></param>
        /// <returns>The <see cref="IEnumerable{T}"/></returns>
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
            );

        /// <summary>
        /// The Add
        /// </summary>
        /// <param name="entity">The entity<see cref="T"/></param>
        void Add(T entity);

        /// <summary>
        /// The Remove
        /// </summary>
        /// <param name="id">The id<see cref="int"/></param>
        void Remove(int id);

        /// <summary>
        /// The Remove
        /// </summary>
        /// <param name="entity">The entity<see cref="T"/></param>
        void Remove(T entity);
    }
}
