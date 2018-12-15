using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cnx.Core.Lib;
using Cnx.Shared.Actions;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public abstract class ReducerBase : IReducer
    {
        public event EventHandler WriteLog;

        private void InvokeWriteLog(string msg) => WriteLog?.Invoke(this, EventArgs.Empty);

        public void ToLog(ActionBase action, string reducerName) => InvokeWriteLog($"{DateTime.Now.ISO8601()} SUCCESS {action.Name}");
    }
}
