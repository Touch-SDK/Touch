using System.Linq;

namespace Touch.Persistence
{
    /// <summary>
    /// Persistence access interface.
    /// </summary>
    public interface IPersistence
    {
        /// <summary>
        /// Return the persistent instance of the given entity class with the given identifier,
        /// or null if there is no such persistent instance.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <param name="id">ID.</param>
        /// <returns>Persistent instance of null.</returns>
        T Get<T>(object id) where T : class, IEntity;

        /// <summary>
        /// Remove a persistent instance from the datastore.
        /// </summary>
        /// <param name="obj">Object to delete.</param>
        void Delete<T>(T obj) where T : class, IEntity;

        /// <summary>
        /// Persist the given transient instance, first assigning an unique identifier.
        /// </summary>
        /// <param name="obj">Objet instance.</param>
        /// <returns>Persisted instance.</returns>
        void Save<T>(T obj) where T : class, IEntity;

        /// <summary>
        /// Update the persistent instance with the identifier of the given transient instance.
        /// </summary>
        /// <param name="obj">Transient instance.</param>
        void Update<T>(T obj) where T : class, IEntity;

        /// <summary>
        /// Create a proxy object with the provided ID.
        /// </summary>
        /// <param name="id">Object ID.</param>
        T Proxy<T>(object id) where T : class, IEntity;

        /// <summary>
        /// Get queryable repository interface.
        /// </summary>
        /// <typeparam name="T">Entity type.</typeparam>
        /// <returns>Queryable interface.</returns>
        IQueryable<T> Query<T>() where T : class, IEntity;

        /// <summary>
        /// Begin a transaction.
        /// </summary>
        ITransaction BeginTransaction();
    }
}
