using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Abstract cache.
    /// </summary>
    /// <typeparam name="T">Cached element type.</typeparam>
    abstract public class AbstractCache<T> : IStore<T>
        where T : class, IDocument
    {
        #region .ctor
        protected AbstractCache(IStore<T> cache, IRepositoryProvider repositoryProvider)
        {
            if (cache == null) throw new ArgumentNullException("cache");
            Cache = cache;

            if (repositoryProvider == null) throw new ArgumentNullException("repositoryProvider");
            RepositoryProvider = repositoryProvider;
        }
        #endregion

        #region Data
        protected readonly IStore<T> Cache;
        protected readonly IRepositoryProvider RepositoryProvider;
        #endregion

        #region Abstract methods
        public abstract T Get(string hashKey);
        public abstract void Delete(T target);
        public abstract void Delete(string hashKey);
        public abstract void Store(T target);
        #endregion
    }
}
