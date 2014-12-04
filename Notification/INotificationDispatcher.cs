using System;

namespace Touch.Notification
{
    /// <summary>
    /// Targeted notification dispatcher.
    /// </summary>
    public interface INotificationDispatcher<in T>
        where T : class, new()
    {
        /// <summary>
        /// Register a notification recipient.
        /// </summary>
        /// <param name="recipient">Notification recipient ID.</param>
        /// <exception cref="NotSupportedException">Recipient registration is not supported.</exception>
        void Register(string recipient);

        /// <summary>
        /// Dispatch a notification to a recipient.
        /// </summary>
        /// <param name="recipient">Notification recipient ID.</param>
        /// <param name="message">Notification message.</param>
        void Dispatch(string recipient, T message);
    }
}
