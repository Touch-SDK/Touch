using System.Collections.Generic;

namespace Touch.Logging
{
    /// <summary>
    /// ILogger provider.
    /// </summary>
    public interface ILoggerProvider
    {
        /// <summary>
        /// Get an <c>ILogger</c> instance for a given type.
        /// </summary>
        /// <typeparam name="T">Caller's type.</typeparam>
        /// <returns><c>ILogger</c> instance.</returns>
        ILogger Get<T>()
            where T : class;
    }
}
