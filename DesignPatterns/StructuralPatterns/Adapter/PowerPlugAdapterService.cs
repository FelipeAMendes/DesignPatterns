namespace DesignPatterns.StructuralPatterns.Adapter;

// Adaptee class
public class PowerPlugAdapterService : IPowerPlugAdapter
{
    public Status ConnectAdapter()
    {
        // Custom operation that is not available or not possible to do on the target...
        return Status.Connected;
    }

    public Status DisconnectAdapter()
    {
        return Status.Disconnected;
    }
}
