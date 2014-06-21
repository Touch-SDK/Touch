using Touch.Domain;

namespace Touch.Notification
{
    /// <summary>
    /// Push notification dispatcher.
    /// </summary>
    public interface INotificationDispatcher
    {
        /// <summary>
        /// Dispatch a notification.
        /// </summary>
        /// <param name="deviceToken">Device token.</param>
        /// <param name="message">Notification alert message.</param>
        /// <param name="count">Badge count.</param>
        void Dispatch(string deviceToken, string message, int count = 0, string data = null);
    }
}
