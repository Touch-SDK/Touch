using System;

namespace Touch.Queue
{
    /// <summary>
    /// Queue provider.
    /// </summary>
    public interface IQueueProvider
    {
        /// <summary>
        /// Get message queue.
        /// </summary>
        /// <typeparam name="T">Message body type.</typeparam>
        /// <param name="queueName">Queue name.</param>
        /// <returns>Message queue.</returns>
        /// <exception cref="ArgumentException">Invalid queue name.</exception>
        IMessageQueue<T> GetQueue<T>(string queueName)
            where T : class, IMessage, new();
    }
}
