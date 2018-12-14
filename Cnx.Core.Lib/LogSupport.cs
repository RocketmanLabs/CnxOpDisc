using System;
using System.Linq;

namespace Cnx.Core.Lib
{
    public class LogSupport
    {
        static public string ExceptionMessage(string source, Exception ex) => $"{DateTime.Now.ISO8601()}|EXCEPTION|{source}|{ex.Message}";
        static public string ErrorMessage(string source, string msg) => $"{DateTime.Now.ISO8601()}|ERROR|{source}|{msg}";
        static public string InfoMessage(string source, string msg) => $"{DateTime.Now.ISO8601()}|INFO|{source}|{msg}";

        static public string ExceptionMessage(string source, Exception ex, params object[] args) => $"{DateTime.Now.ISO8601()}|EXCEPTION|{source}|{ex.Message}{args.All(a => { ObjectDumper.Dump(a); return true; })}";
        static public string ErrorMessage(string source, string msg, params object[] args) => $"{DateTime.Now.ISO8601()}|ERROR|{source}|{msg}{args.All(a => { ObjectDumper.Dump(a); return true; })}";
        static public string InfoMessage(string source, string msg, params object[] args) => $"{DateTime.Now.ISO8601()}|INFO|{source}|{msg}{args.All(a => { ObjectDumper.Dump(a); return true; })}";
    }
}
