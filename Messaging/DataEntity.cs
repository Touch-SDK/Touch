using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Touch.Messaging
{
    [DataContract]
    public abstract class DataEntity : IDataEntity
    {
        [DataMember(Name = "token")]
        public Guid Token { get; set; }
    }
}
