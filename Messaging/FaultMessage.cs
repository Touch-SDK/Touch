using System.Runtime.Serialization;

namespace Touch.Messaging
{
    /// <summary>
    /// Service fault message.
    /// </summary>
    [DataContract(Name = "touch.FaultMessage", Namespace = "http://api.managesnap.com")]
    public class FaultMessage
    {
        /// <summary>
        /// Message.
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
