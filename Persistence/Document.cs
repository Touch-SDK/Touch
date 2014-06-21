using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Document.
    /// </summary>
    abstract public class Document : IDocument
    {
        #region IDocument implementation
        /// <summary>
        /// Documents's hash key.
        /// </summary>
        public abstract string HashKey { get; set; }
        #endregion

        #region IEquatable implementation
        public virtual bool Equals(Document obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return obj.HashKey.Equals(HashKey) && HashKey != null && obj.HashKey != null;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;
            return Equals(obj as Document);
        }

        public virtual bool Equals(IDocument other) { return Equals(other as Document); }

        public override int GetHashCode() { return (HashKey == null ? base.GetHashCode() : HashKey.GetHashCode()) ^ GetType().GetHashCode(); }

        public static bool operator ==(Document left, Document right) { return Equals(left, right); }

        public static bool operator !=(Document left, Document right) { return !Equals(left, right); }
        #endregion
    }
}
