namespace DesignPatterns.StructuralPatterns.Adapter;

public class ClientAdapter
{
    private readonly IPowerPlug _powerPlug;
    public IPowerPlug Adaptee { get; }

    public ClientAdapter(IPowerPlug powerPlug)
    {
        _powerPlug = powerPlug;
        Adaptee = _powerPlug;
    }

    public Status Connect()
    {
        return _powerPlug.Connect();
    }

    public Status Disconnect()
    {
        return _powerPlug.Disconnect();
    }
}
