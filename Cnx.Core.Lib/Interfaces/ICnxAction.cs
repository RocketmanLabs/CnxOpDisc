namespace Cnx.Core.Lib.Interfaces
{
    public interface ICnxAction : Redux.IAction
    {
        string Name { get; }
    }
}