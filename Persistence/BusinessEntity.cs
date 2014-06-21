using System;
using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// Business entity.
    /// </summary>
    abstract public class BusinessEntity : IBusinessEntity
    {
        #region IBusinessEntity implementation
        /// <summary>
        /// Entity has been removed.
        /// </summary>
        public virtual bool IsRemoved { get; set; }

        /// <summary>
        /// Globally unique business entity ID.
        /// </summary>
        public virtual Guid Id { get; set; }
        #endregion

        #region IEntity implementation
        /// <summary>
        /// Object's identity.
        /// </summary>
        public virtual object Identity { get { return Id != Guid.Empty ? Id : default(object); } }
        #endregion

        #region IEquatable implementation
        public virtual bool Equals(BusinessEntity obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.Identity == null || Identity == null) return false;
            if (obj.Id == default(Guid) || Id == default(Guid)) return false;
            return obj.Identity.Equals(Identity);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return Equals(obj as BusinessEntity);
        }

        public virtual bool Equals(IEntity other) { return Equals(other as BusinessEntity); }

        public override int GetHashCode() { return (Identity == null ? base.GetHashCode() : Identity.GetHashCode()) ^ GetType().GetHashCode(); }

        public static bool operator ==(BusinessEntity left, BusinessEntity right) { return Equals(left, right); }

        public static bool operator !=(BusinessEntity left, BusinessEntity right) { return !Equals(left, right); }
        #endregion

        #region Protected methods
        protected IEnumerable<T> CreateCollection<T>()
            where T : class, IEntity
        {
            return new List<T>();
        }

        protected void AddToCollection<T>(T entity, IEnumerable<T> collection)
            where T : class, IEntity
        {
            if (entity == null) throw new ArgumentNullException("entity");
            if (collection == null) throw new ArgumentNullException("collection");

            ((IList<T>)collection).Add(entity);
        }
        #endregion

        #region IEqualityComparer members
        public static IEqualityComparer<BusinessEntity> DefaultComparer
        {
            get
            {
                return new BusinessEntityEqualityComparer();
            }
        }

        sealed private class BusinessEntityEqualityComparer : IEqualityComparer<BusinessEntity>
        {
            public bool Equals(BusinessEntity x, BusinessEntity y)
            {
                return x.Equals(y);
            }

            public int GetHashCode(BusinessEntity obj)
            {
                return obj.GetHashCode();
            }
        }
        #endregion
    }
}
