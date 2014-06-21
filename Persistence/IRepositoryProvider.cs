using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// Repository provider.
    /// </summary>
    public interface IRepositoryProvider
    {
        /// <summary>
        /// Get repository instance.
        /// </summary>
        /// <typeparam name="T">Repository entities type.</typeparam>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException">Repository for a given entity type not found.</exception>
        IRepository<T> GetRepository<T>()
            where T : class, IEntity;

        /// <summary>
        /// Get business repository instance.
        /// </summary>
        /// <typeparam name="T">Repository business entities type.</typeparam>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException">Repository for a given business entity type not found.</exception>
        IBusinessRepository<T> GetBusinessRepository<T>()
            where T : class, IBusinessEntity;

        /// <summary>
        /// Begin a transaction.
        /// </summary>
        ITransaction BeginTransaction();
    }
}
