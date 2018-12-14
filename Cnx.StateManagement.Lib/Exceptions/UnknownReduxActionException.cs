using System;
using System.Runtime.Serialization;
using Cnx.Core.Lib;
using Cnx.StateManagement.Lib.Interfaces;
using Redux;

namespace Cnx.StateManagement.Lib.Exceptions
{
    [Serializable]
    internal class UnknownReduxActionException : Exception
    {
        public UnknownReduxActionException() { }

        public UnknownReduxActionException(string source, ICnxAction action) : base(LogSupport.ErrorMessage(source, $"Unknown action: {action} in {source}")) { }
    }
}