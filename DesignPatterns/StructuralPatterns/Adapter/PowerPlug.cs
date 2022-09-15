namespace DesignPatterns.StructuralPatterns.Adapter;

// Target class
public class PowerPlug : IPowerPlug
{
    private Status _status;

    public Status Connect()
    {
        _status = Status.Connected;
        return _status;
    }

    public Status Disconnect()
    {
        _status = Status.Disconnected;
        return _status;
    }
}
