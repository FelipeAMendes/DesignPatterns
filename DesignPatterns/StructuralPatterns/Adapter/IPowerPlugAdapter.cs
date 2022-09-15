namespace DesignPatterns.StructuralPatterns.Adapter;

// Adaptee
public interface IPowerPlugAdapter
{
    Status ConnectAdapter();
    Status DisconnectAdapter();
}
