using System;

namespace Touch.Persistence
{
    /// <summary>
    /// Business entity.
    /// </summary>
    public interface IBusinessEntity : IEntity
    {
        /// <summary>
        /// Globally unique business entity ID.
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Business entity has been removed. An entity with this property set to <c>true</c> will not appear when fetching it with 
        /// <c>IBusinessRepository.Get</c> method.  Be cautious though that when quierying a repository an <c>IsRemoved</c> property is not
        /// respected automatically. This property should not be set to <c>true</c> explicitly. Instead, consider using <c>Delete</c>
        /// method of <c>IBusinessRepository</c>.
        /// </summary>
        bool IsRemoved { get; set; }
    }
}
