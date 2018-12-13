using Cnx.StateManagement.Lib;
using Redux;
using Redux.DevTools;

namespace Cnx.StateManagement.Lib
{
    public class StateManager
    {
        public static IStore<int> AppStore { get; private set; }
        public static int Value;

        public StateManager()
        {
            AppStore = new Store<int>(reducer: CnxStateReducer.Execute, initialState: 1);
            //AppStore = new TimeMachineStore<int>(reducer: CnxStateReducer.Execute, initialState: 1);
            // AppStore.Subscribe() hooks changes up to state
            // AppStore.DistinctUntilChanged(create new state).Subscribe(use state to get output)
        }
    
    }
}
