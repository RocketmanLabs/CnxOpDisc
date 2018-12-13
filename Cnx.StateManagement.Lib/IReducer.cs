﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Redux;

namespace Cnx.StateManagement.Lib
{
    public interface IReducer
    {
        void ToLog(IAction action, string reducerName);
    }
}
