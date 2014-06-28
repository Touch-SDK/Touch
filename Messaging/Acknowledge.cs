using System;
using System.Runtime.Serialization;

namespace Touch.Messaging
{
    /// <summary>
    /// Service acknowledge.
    /// </summary>
    [DataContract(Name = "touch.Acknowledge", Namespace = "http://api.managesnap.com")]
    public class Acknowledge
    {
        
    }

    /// <summary>
    /// Service acknowledge.
    /// </summary>
    [DataContract(Name = "touch.AddAcknowledge", Namespace = "http://api.managesnap.com")]
    public class AddAcknowledge
    {
        /// <summary>
        /// Result token.
        /// </summary>
        [DataMember(Name = "token")]
        public Guid Token { get; set; }
    }
}
