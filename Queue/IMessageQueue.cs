﻿using System.Collections.Generic;

namespace Touch.Queue
{
    /// <summary>
    /// A queue of messages.
    /// </summary>
    /// <typeparam name="T">Message body type.</typeparam>
    public interface IMessageQueue<T>
        where T : class, new()
    {
        /// <summary>
        /// Add message to the queue.
        /// </summary>
        /// <param name="message">Message to add.</param>
        void Enqueue(T message);

        /// <summary>
        /// Get messages from the queue.
        /// </summary>
        /// <param name="take">Maximum number of messages to take.</param>
        /// <returns></returns>
        IEnumerable<IQueueItem<T>> Dequeue(uint take);

        /// <summary>
        /// Remove message from the queue.
        /// </summary>
        /// <param name="message">Message to remove from the queue.</param>
        void DeleteMessage(IQueueItem<T> message);
    }
}
