using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public abstract class ReducerBase : IReducer
    {
        public event EventHandler WriteLog;

        private void InvokeWriteLog(IAction action, string reducerName) => WriteLog?.Invoke(this, EventArgs.Empty);

        public void ToLog(IAction action, string reducerName) => InvokeWriteLog($"{DateTime.Now.ISO8601()} SUCCESS {action.Name}");
    }
}
