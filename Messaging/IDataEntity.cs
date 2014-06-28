using System;

namespace Touch.Messaging
{
    /// <summary>
    /// Data entity.
    /// </summary>
    public interface IDataEntity
    {
        /// <summary>
        /// Token.
        /// </summary>
        Guid Token { get; }
    }
}
