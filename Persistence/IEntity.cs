using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Entity.
    /// </summary>
    public interface IEntity : IEquatable<IEntity>
    {
        /// <summary>
        /// Object's identity. Is <c>null</c> if an entity is not persisted.
        /// </summary>
        object Identity { get; }
    }
}
