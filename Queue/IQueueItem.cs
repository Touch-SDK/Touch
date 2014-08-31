using System;

namespace Touch.Queue
{
    /// <summary>
    /// An IMessageQueue message.
    /// </summary>
    public interface IQueueItem<T> : IEquatable<IQueueItem<T>>
        where T : class, new()
    {
        /// <summary>
        /// Message ID.
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Receipt.
        /// </summary>
        string Receipt { get; }

        /// <summary>
        /// Message body.
        /// </summary>
        T Body { get; }
    }
}
