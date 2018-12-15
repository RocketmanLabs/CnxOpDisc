using System;
using Cnx.Core.Lib;
using Cnx.Core.Lib.Interfaces;

namespace Cnx.StateManagement.Lib.Exceptions
{
    [Serializable]
    internal class UnknownReduxActionException : Exception
    {
        public UnknownReduxActionException() { }

        public UnknownReduxActionException(string source, ICnxAction action) : base(LogSupport.ErrorMessage(source, $"Unknown action: {action} in {source}")) { }
    }
}