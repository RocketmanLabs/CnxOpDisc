using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;

namespace Cnx.Shared.Actions
{
    public abstract class ActionBase : IAction
    {
        public string Name => this.GetType().Name;
    }
}
