using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cnx.Core.Lib
{
    public static class DateTime_Extension_Methods
    {
        static public string ISO8601(this DateTime dt)
        {
            return dt.ToString("yyyy-MM-ddThh:mm:ss");
        }
    }
}
