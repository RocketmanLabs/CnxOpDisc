using Cnx.Core.Lib;
using Cnx.StateManagement.Lib;
using Redux;

namespace Cnx.StateManagement.Lib
{
    /// <summary>
    /// https://www.dotnetcurry.com/reactjs/1356/redux-pattern-tutorial
    /// https://github.com/GuillaumeSalles/redux.NET
    /// </summary>
    public class StateManager
    {
        public static IStore<Dto> AppStore { get; private set; }
        public static int Value;

        public StateManager()
        {
            AppStore = new Store<Dto>(reducer: CnxStateReducer.Execute, initialState: null);
            // with DevTools: AppStore = new TimeMachineStore<int>(reducer: CnxStateReducer.Execute, initialState: 1);
            // AppStore.Subscribe() hooks changes up to state
            // AppStore.DistinctUntilChanged(create new state).Subscribe(use state to get output)
        }
    
    }
}
