namespace DesignPatterns.StructuralPatterns.Adapter;

// Adapter class
public class PowerPlugAdapter : IPowerPlug
{
    private readonly IPowerPlugAdapter _powerPlugAdapter;

    public PowerPlugAdapter(IPowerPlugAdapter powerPlugAdapter)
    {
        _powerPlugAdapter = powerPlugAdapter;
    }

    public Status Connect()
    {
        return _powerPlugAdapter.ConnectAdapter();
    }

    public Status Disconnect()
    {
        return _powerPlugAdapter.DisconnectAdapter();
    }
}
