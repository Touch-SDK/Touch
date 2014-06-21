namespace Touch.Persistence
{
    /// <summary>
    /// <c>IPersistence</c> provider.
    /// </summary>
    public interface IPersistenceProvider
    {
        /// <summary>
        /// Get persistence session.
        /// </summary>
        /// <returns>Persistence session.</returns>
        IPersistence GetSession();
    }
}
