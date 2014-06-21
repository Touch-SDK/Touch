using System;
using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// Entity.
    /// </summary>
    abstract public class Entity : IEntity
    {
        #region Properties
        /// <summary>
        /// Internal object's ID.
        /// </summary>
        public virtual int? Id { get; protected set; }
        #endregion

        #region IEntity implementation
        /// <summary>
        /// Object's identity.
        /// </summary>
        public virtual object Identity { get { return Id; } }
        #endregion

        #region IEquatable implementation
        public virtual bool Equals(Entity obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return obj.Identity.Equals(Identity);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals(obj as Entity);
        }

        public virtual bool Equals(IEntity other) { return Equals(other as Entity); }

        public override int GetHashCode() { return (Identity == null ? base.GetHashCode() : Identity.GetHashCode()) ^ GetType().GetHashCode(); }

        public static bool operator ==(Entity left, Entity right) { return Equals(left, right); }

        public static bool operator !=(Entity left, Entity right) { return !Equals(left, right); }
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
            
            ((IList<T>) collection).Add(entity);
        }
        #endregion
    }
}
