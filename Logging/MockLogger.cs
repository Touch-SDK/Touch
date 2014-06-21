﻿using System;

namespace Touch.Logging
{
    /// <summary>
    /// Mock <c>ILogger</c>.
    /// </summary>
    sealed public class MockLogger : ILogger
    {
        private sealed class MockStack : IDisposable
        {
            public void Dispose()
            {
            }
        }

        public Type OwnerType { get; set; }

        public IDisposable Stack(string name)
        {
            return new MockStack();
        }

        public void Debug(string message)
        {
        }

        public void Debug(string message, Exception exception)
        {
        }

        public void DebugFormat(string format, params object[] args)
        {
        }

        public void DebugFormat(Exception exception, string format, params object[] args)
        {
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public bool IsDebugEnabled{get { return false; }}

        public void Info(string message)
        {
        }

        public void Info(string message, Exception exception)
        {
        }

        public void InfoFormat(string format, params object[] args)
        {
        }

        public void InfoFormat(Exception exception, string format, params object[] args)
        {
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public bool IsInfoEnabled{get { return false; }}

        public void Warn(string message)
        {
        }

        public void Warn(string message, Exception exception)
        {
        }

        public void WarnFormat(string format, params object[] args)
        {
        }

        public void WarnFormat(Exception exception, string format, params object[] args)
        {
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public bool IsWarnEnabled{get { return false; }}

        public void Error(string message)
        {
        }

        public void Error(string message, Exception exception)
        {
        }

        public void ErrorFormat(string format, params object[] args)
        {
        }

        public void ErrorFormat(Exception exception, string format, params object[] args)
        {
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public bool IsErrorEnabled{get { return false; }}

        public void Fatal(string message)
        {
        }

        public void Fatal(string message, Exception exception)
        {
        }

        public void FatalFormat(string format, params object[] args)
        {
        }

        public void FatalFormat(Exception exception, string format, params object[] args)
        {
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
        }

        public bool IsFatalEnabled{get { return false; }}
    }
}
