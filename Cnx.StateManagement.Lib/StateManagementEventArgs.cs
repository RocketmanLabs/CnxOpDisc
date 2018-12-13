using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public class StateManagementEventArgs
    {
        public IAction Action { get; private set; }
        public string Message { get; private set; }
        public bool IsException { get; private set; }

        public StateManagementEventArgs() { }

        public StateManagementEventArgs(IAction action, string message)
        {
            this.Action = action;
            this.Message = message;
        }

        public StateManagementEventArgs(IAction action, Exception ex)
        {
            this.Action = action;
            this.Message = ex.Message;
            this.IsException = true;
        }
    }
}
