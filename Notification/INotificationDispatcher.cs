namespace Touch.Notification
{
    /// <summary>
    /// Targeted notification dispatcher.
    /// </summary>
    public interface INotificationDispatcher<in T>
        where T : class, new()
    {
        /// <summary>
        /// Dispatch a notification to a recipient.
        /// </summary>
        /// <param name="recipient">Notification recipient.</param>
        /// <param name="message">Notification message.</param>
        void Dispatch(string recipient, T message);
    }
}
