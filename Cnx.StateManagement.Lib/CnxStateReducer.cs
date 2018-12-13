using Cnx.StateManagement.Lib.Actions;
using Cnx.StateManagement.Lib.Exceptions;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public class CnxStateReducer : ReducerBase
    {
        // base: void ToLog(action, reducerName);

        public static int Execute(int state, IAction action)
        {
            if (action is IncrementAction) {
                return state + 1;
            }
            if (action is DecrementAction) {
                return state - 1;
            }
            throw new UnknownReduxActionException(action, "SysInfoReducer");
        }
    }
}
