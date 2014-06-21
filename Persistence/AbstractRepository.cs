using System;
using System.Diagnostics;
using System.Linq;

namespace Touch.Persistence
{
    /// <summary>
    /// Abstract repository.
    /// </summary>
    /// <typeparam name="T">Repository entity type.</typeparam>
    abstract public class AbstractRepository<T> : IRepository<T>
        where T : class, IEntity, new()
    {
        #region Data
        /// <summary>
        /// Session provider.
        /// </summary>
        private readonly IPersistenceProvider _provider;
        #endregion

        #region .ctor
        protected AbstractRepository(IPersistenceProvider provider)
        {
            if (provider == null) throw new ArgumentNullException("provider");
            _provider = provider;
        }
        #endregion

        #region Abstract methods
        /// <summary>
        /// Handle process operation execution and handle IRepository exceptions.
        /// </summary>
        /// <param name="func">Function to execute.</param>
        /// <returns>Function result.</returns>
        /// <exception cref="Exceptions.ObjectNotFoundException" />
        /// <exception cref="Exceptions.ObjectNotUniqueException" />
        protected abstract T TryCatch(Func<T> func);
        #endregion

        #region IRepository<T> Members
        [DebuggerStepThrough]
        virtual public T Get(object id)
        {
            return TryCatch(() => GetSession().Get<T>(id));
        }

        [DebuggerStepThrough]
        virtual public void Delete(T target)
        {
            TryCatch(() =>
            {
                GetSession().Delete(target);
                return null;
            });
        }

        [DebuggerStepThrough]
        virtual public void Save(T target)
        {
            TryCatch(() =>
            {
                GetSession().Save(target);
                return target;
            });
        }

        [DebuggerStepThrough]
        virtual public void Update(T target)
        {
            TryCatch(() =>
            {
                GetSession().Update(target);
                return target;
            });
        }

        [DebuggerStepThrough]
        virtual public T Proxy(object id)
        {
            return TryCatch(() => GetSession().Proxy<T>(id));
        }

        [DebuggerStepThrough]
        virtual public IQueryable<T> Query()
        {
            return GetSession().Query<T>();
        }
        #endregion

        #region Helper methods
        protected IPersistence GetSession()
        {
            return _provider.GetSession();
        }
        #endregion
    }

    /// <summary>
    /// Abstract business repository.
    /// </summary>
    /// <typeparam name="T">Repository business entity type.</typeparam>
    abstract public class AbstractBusinessRepository<T> : AbstractRepository<T>, IBusinessRepository<T>
        where T : class, IBusinessEntity, new()
    {
        #region .ctor
        protected AbstractBusinessRepository(IPersistenceProvider provider)
            : base(provider)
        {}
        #endregion

        #region IBusinessRepository<T> members
        [DebuggerStepThrough]
        public T Get(Guid token)
        {
            var entity = base.Get(token);

            return entity != null && !entity.IsRemoved
                       ? entity
                       : null;
        }

        [DebuggerStepThrough]
        override public T Get(object id)
        {
            var entity = base.Get(id);

            return entity != null && !entity.IsRemoved
                       ? entity
                       : null;
        }

        [DebuggerStepThrough]
        public T Proxy(Guid id)
        {
            return TryCatch(() => GetSession().Proxy<T>(id));
        }

        [DebuggerStepThrough]
        override public void Delete(T target)
        {
            TryCatch(() =>
            {
                target.IsRemoved = true;
                Save(target);
                return null;
            });
        }

        [DebuggerStepThrough]
        public void Destroy(T target)
        {
            base.Delete(target);
        }

        public abstract void Destroy(Guid token);
        #endregion
    }
}
