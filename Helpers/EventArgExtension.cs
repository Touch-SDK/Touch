using System;
using System.Threading;
using System.ComponentModel;

namespace Touch
{
    public static class EventArgExtension
    {
        public static void Raise<TEventArgs>(this TEventArgs e, object sender, ref EventHandler eventDelegate)
            where TEventArgs : EventArgs
        {
            var temp = Interlocked.CompareExchange(ref eventDelegate, null, null);

            if (temp != null) temp(sender, e);
        }

        public static void Raise<TEventArgs>(this TEventArgs e, object sender, ref EventHandler<TEventArgs> eventDelegate)
            where TEventArgs : EventArgs
        {
            var temp = Interlocked.CompareExchange(ref eventDelegate, null, null);

            if (temp != null) temp(sender, e);
        }

        public static void Raise<TEventArgs>(this TEventArgs e, object sender, ref PropertyChangedEventHandler eventDelegate)
            where TEventArgs : PropertyChangedEventArgs
        {
            var temp = Interlocked.CompareExchange(ref eventDelegate, null, null);

            if (temp != null) temp(sender, e);
        }
    }
}
