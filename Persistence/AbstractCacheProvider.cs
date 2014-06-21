using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Abstract cache provider.
    /// </summary>
    public abstract class AbstractCacheProvider : IStoreProvider
    {
        #region .ctor
        protected AbstractCacheProvider(IStoreProvider cacheProvider, IRepositoryProvider dataProvider)
        {
            if (cacheProvider == null) throw new ArgumentNullException("cacheProvider");
            CacheProvider = cacheProvider;

            if (dataProvider == null) throw new ArgumentNullException("dataProvider");
            DataProvider = dataProvider;
        }
        #endregion

        #region Data
        protected readonly IStoreProvider CacheProvider;
        protected readonly IRepositoryProvider DataProvider;
        #endregion

        #region Abstract methods
        public abstract IStore<T> GetStore<T>() where T : class, IDocument;
        #endregion
    }
}
