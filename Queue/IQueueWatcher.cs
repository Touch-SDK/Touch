using System;

namespace Touch.Queue
{
    /// <summary>
    /// Represents a class that can watch and retrieve new elements from an INotificationQueue.
    /// </summary>
    /// <typeparam name="T">Notification type.</typeparam>
    public interface IQueueWatcher<T> : IDisposable
        where T : class, new()
    {
        /// <summary>
        /// Start watching the queue for new notifications.
        /// </summary>
        /// <param name="queue">Queue to watch.</param>
        /// <param name="handler">New notification handler.</param>
        void StartWatching(IMessageQueue<T> queue, HandleNewQueueItem<T> handler);

        /// <summary>
        /// Stop watching the queue for new notifications.
        /// </summary>
        void StopWatching();

        /// <summary>
        /// The watcher is active and is trying to get new notifications from the queue.
        /// </summary>
        bool IsWatching { get; }
    }

    /// <summary>
    /// Delegate for recieving new notifications from the queue.
    /// </summary>
    /// <typeparam name="T">Notification type.</typeparam>
    /// <param name="message">Notification instance.</param>
    public delegate void HandleNewQueueItem<in T>(T message)
        where T : class, new();
}
