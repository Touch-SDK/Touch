using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// Document store provider.
    /// </summary>
    public interface IStoreProvider
    {
        /// <summary>
        /// Get document store instance.
        /// </summary>
        /// <typeparam name="T">Store documents type.</typeparam>
        /// <returns></returns>
        /// <exception cref="KeyNotFoundException">Store for a given document type not found.</exception>
        IStore<T> GetStore<T>() where T : class, IDocument;
    }
}
