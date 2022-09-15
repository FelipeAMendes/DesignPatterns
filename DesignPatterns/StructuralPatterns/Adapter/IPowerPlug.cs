namespace DesignPatterns.StructuralPatterns.Adapter;

// Target
public interface IPowerPlug
{
    Status Connect();
    Status Disconnect();
}
