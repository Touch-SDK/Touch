using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// Document store context.
    /// </summary>
    public interface IContext
    {
        /// <summary>
        /// Get document by hash key.
        /// </summary>
        /// <param name="hashKey">Document hash key.</param>
        /// <returns>Matching document or <c>null</c>.</returns>
        T Get<T>(string hashKey) where T : class, IDocument;

        /// <summary>
        /// Remove document from store.
        /// </summary>
        /// <param name="target">Target document.</param>
        void Delete<T>(T target) where T : class, IDocument;

        /// <summary>
        /// Delete document from store by hash key.
        /// </summary>
        /// <param name="hashKey">Target document hash key.</param>
        void Delete<T>(string hashKey) where T : class, IDocument;

        /// <summary>
        /// Store a document.
        /// </summary>
        /// <param name="target">Document to store.</param>
        void Store(IDocument target);

        /// <summary>
        /// Query the document store.
        /// </summary>
        /// /// <param name="condition">Field name and value condition to use in the query.</param>
        IEnumerable<T> Query<T>(KeyValuePair<string, string> condition) where T : class, IDocument;
    }
}
