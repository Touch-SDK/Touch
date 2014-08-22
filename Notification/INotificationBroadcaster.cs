namespace Touch.Notification
{
    /// <summary>
    /// Notification broadcaster.
    /// </summary>
    /// <typeparam name="T">Notification type.</typeparam>
    public interface INotificationBroadcaster<in T>
        where T : class, new()
    {
        /// <summary>
        /// Broadcast a notification.
        /// </summary>
        /// <param name="notification">Notification to broadcast.</param>
        void Broadcast(T notification);
    }
}
