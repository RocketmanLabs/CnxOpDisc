using System;
using System.Runtime.Serialization;
using Cnx.Core.Lib;
using Redux;

namespace Cnx.StateManagement.Lib.Exceptions
{
    [Serializable]
    internal class UnknownReduxActionException : Exception
    {
        private IAction action;
        private string v;

        public UnknownReduxActionException()
        {
        }

        public UnknownReduxActionException(string message) : base(message)
        {
        }

        public UnknownReduxActionException(IAction action, string msg) : base($"{DateTime.Now.ISO8601()} EXCEPTION {} {}")
        {
            this.action = action;
            this.v = msg;
        }

        public UnknownReduxActionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnknownReduxActionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}