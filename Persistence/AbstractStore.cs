using System;
using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// Abstract document store.
    /// </summary>
    /// <typeparam name="T">Store document type.</typeparam>
    abstract public class AbstractStore<T> : IStore<T>
        where T : class, IDocument
    {
        #region .ctor
        protected AbstractStore(IContextProvider provider)
        {
            if (provider == null) throw new ArgumentNullException("provider");
            Provider = provider;
        }
        #endregion

        #region Data
        /// <summary>
        /// Context provider.
        /// </summary>
        protected readonly IContextProvider Provider;
        #endregion

        #region Abstract methods
        /// <summary>
        /// Handle process operation execution and handle IStore exceptions.
        /// </summary>
        /// <param name="func">Function to execute.</param>
        /// <returns>Function result.</returns>
        /// <exception cref="Exceptions.ObjectNotFoundException" />
        /// <exception cref="Exceptions.ObjectNotUniqueException" />
        protected abstract TR TryCatch<TR>(Func<TR> func);
        #endregion

        #region IStore<T> Members
        public T Get(string hashKey)
        {
            return TryCatch(() => GetContext().Get<T>(hashKey));
        }

        public void Delete(T target)
        {
            TryCatch<object>(() =>
            {
                GetContext().Delete(target);
                return null;
            });
        }

        public void Delete(string hashKey)
        {
            TryCatch<object>(() =>
            {
                GetContext().Delete<T>(hashKey);
                return null;
            });
        }

        public void Store(T target)
        {
            TryCatch<object>(() =>
            {
                GetContext().Store(target);
                return null;
            });
        }

        public IEnumerable<T> Query(KeyValuePair<string,string> condition)
        {
            return TryCatch(() => GetContext().Query<T>(condition));
        }
        #endregion

        #region Helper methods
        protected IContext GetContext()
        {
            return Provider.GetContext();
        }
        #endregion
    }
}
