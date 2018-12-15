using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;
using Cnx.Shared.Actions;

namespace Cnx.StateManagement.Lib
{
    public interface IReducer
    {
        void ToLog(ActionBase action, string source);
    }
}
