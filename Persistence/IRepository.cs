using System;
using System.Linq;

namespace Touch.Persistence
{
    /// <summary>
    /// Repository that contains entities of type T.
    /// </summary>
    /// <typeparam name="T">Type of entities.</typeparam>
    public interface IRepository<T>
        where T : class, IEntity
    {
        /// <summary>
        /// Get entity by ID.
        /// </summary>
        /// <param name="id">ID.</param>
        /// <returns>Matching entity.</returns>
        T Get(object id);

        /// <summary>
        /// Remove entity from repository.
        /// </summary>
        /// <param name="target">Target entity.</param>
        void Delete(T target);

        /// <summary>
        /// Get queryable repository object.
        /// </summary>
        /// <returns></returns>
        IQueryable<T> Query();

        /// <summary>
        /// Add new entity to repository.
        /// </summary>
        /// <param name="target">Entity to add.</param>
        /// <returns>Saved entity.</returns>
        void Save(T target);

        /// <summary>
        /// Update an existing entity.
        /// </summary>
        /// <param name="target">Entity to update.</param>
        /// <returns>Updated entity.</returns>
        void Update(T target);

        /// <summary>
        /// Create a proxy object with the provided ID.
        /// </summary>
        /// <param name="id">Object ID.</param>
        T Proxy(object id);
    }

    /// <summary>
    /// Repository that contains business entities of type T.
    /// </summary>
    /// <typeparam name="T">Type of business entities.</typeparam>
    public interface IBusinessRepository<T> : IRepository<T>
        where T : class, IBusinessEntity
    {
        /// <summary>
        /// Get business entity by token.
        /// </summary>
        /// <param name="token">Token.</param>
        /// <returns>Matching business entity.</returns>
        T Get(Guid token);

        /// <summary>
        /// Permanently remove entity from repository.
        /// </summary>
        /// <param name="target">Target entity.</param>
        void Destroy(T target);

        /// <summary>
        /// Permanently remove business entity by token.
        /// </summary>
        /// <param name="token">Token.</param>
        void Destroy(Guid token);

        /// <summary>
        /// Create a proxy object with the provided ID.
        /// </summary>
        /// <param name="id">Object ID.</param>
        T Proxy(Guid id);
    }
}
