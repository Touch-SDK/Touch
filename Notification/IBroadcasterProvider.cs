using System;

namespace Touch.Notification
{
    /// <summary>
    /// Notification broadcaster provider.
    /// </summary>
    public interface IBroadcasterProvider
    {
        /// <summary>
        /// Get notification broadcaster for topic.
        /// </summary>
        /// <typeparam name="T">Notification type.</typeparam>
        /// <param name="topicName">Notification topic name.</param>
        /// <exception cref="ArgumentException">Invalid queue name.</exception>
        INotificationBroadcaster<T> GetBroadcaster<T>(string topicName)
            where T : class, INotification, new();
    }
}
