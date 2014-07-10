using System;

namespace Touch.Storage
{
    /// <summary>
    /// Media encoder job.
    /// </summary>
    public abstract class MediaEncoderJob
    {
        public virtual Guid Token { get; protected set; }

        public virtual string Source { get; protected set; }

        public virtual string Output { get; protected set; }

        public virtual DateTime Started { get; protected set; }

        public virtual MediaEncoderJobStatus Status { get; protected set; }
    }

    public enum MediaEncoderJobStatus
    {
        Started,
        Complete,
        Failed
    }
}
