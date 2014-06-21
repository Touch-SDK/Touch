using System;
using Touch.Persistence;

namespace Touch.Domain
{
    static public class StoreExtensions
    {
        /// <see cref="IStore{T}.Get"/>
        public static T Get<T>(this IStore<T> store, Guid hashKey)
            where T : class, IDocument
        {
            return store.Get(hashKey.ToTokenString());
        }

        /// <see cref="IStore{T}.Delete"/>
        public static void Delete<T>(this IStore<T> store, Guid hashKey)
            where T : class, IDocument
        {
            store.Delete(hashKey.ToTokenString());
        }
    }
}
