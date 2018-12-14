namespace Cnx.StateManagement.Lib.Interfaces
{
    public interface ICnxAction : Redux.IAction
    {
        string Name { get; }
    }
}