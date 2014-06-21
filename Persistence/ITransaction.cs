using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Persistence transaction.
    /// </summary>
    public interface ITransaction : IDisposable
    {
        /// <summary>
        /// Commit the transaction.
        /// </summary>
        void Commit();

        /// <summary>
        /// Rollback the transaction.
        /// </summary>
        void Rollback();
    }
}
