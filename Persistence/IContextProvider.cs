namespace Touch.Persistence
{
    /// <summary>
    /// <c>IContext</c> provider.
    /// </summary>
    public interface IContextProvider
    {
        /// <summary>
        /// Get document store context.
        /// </summary>
        IContext GetContext();
    }
}
