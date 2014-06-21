namespace Touch.Logging
{
    /// <summary>
    /// Mock <c>ILoggerProvider</c>.
    /// </summary>
    sealed public class MockLoggerProvider : ILoggerProvider
    {
        public ILogger Get<T>() where T : class
        {
            return new MockLogger();
        }
    }
}
