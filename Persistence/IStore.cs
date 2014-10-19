using System;
using System.Collections.Generic;

namespace Touch.Persistence
{
    /// <summary>
    /// A store of documents of type T.
    /// </summary>
    /// <typeparam name="T">Type of documents.</typeparam>
    public interface IStore<T>
        where T : class, IDocument
    {
        /// <summary>
        /// Get document by hash key.
        /// </summary>
        /// <param name="hashKey">Document hash key.</param>
        /// <returns>Matching document.</returns>
        T Get(string hashKey);

        /// <summary>
        /// Remove document from store.
        /// </summary>
        /// <param name="target">Target document.</param>
        void Delete(T target);

        /// <summary>
        /// Delete document from store by hash key.
        /// </summary>
        /// <param name="hashKey">Target document hash key.</param>
        void Delete(string hashKey);

        /// <summary>
        /// Store a document.
        /// </summary>
        /// <param name="target">Document to store.</param>
        void Store(T target);

        /// <summary>
        /// Query the document store.
        /// </summary>
        /// <param name="condition">Field name and value condition to use in the query.</param>
        /// <returns>Matching documents.</returns>
        /// <exception cref="NotSupportedException">Store does not support querying.</exception>
        IEnumerable<T> Query(KeyValuePair<string,string> condition);
    }
}
