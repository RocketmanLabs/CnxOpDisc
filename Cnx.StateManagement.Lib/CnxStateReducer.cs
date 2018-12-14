using Cnx.StateManagement.Lib.Actions;
using Cnx.StateManagement.Lib.Exceptions;
using Cnx.StateManagement.Lib.Interfaces;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public class CnxStateReducer : ReducerBase
    {
        // base: void ToLog(action, reducerName);

        public static T Execute<T>(int state, ICnxAction action) where T:class
        {
            if (action is IncrementAction) {
                return state + 1;
            }
            if (action is DecrementAction) {
                return state - 1;
            }
            throw new UnknownReduxActionException("CnxStateReducer", action);
        }
    }
}
