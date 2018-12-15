using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnx.Core.Lib
{
    public class CnxEventArgs : EventArgs
    {
        public string Message { get; private set; }

        public CnxEventArgs() { }

        public CnxEventArgs(string msg)
        {
            this.Message = msg;
        }
    }
}
