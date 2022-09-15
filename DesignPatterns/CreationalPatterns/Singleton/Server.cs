namespace DesignPatterns.CreationalPatterns.Singleton;

public class Server
{
    public Server(Guid id, string name, string ipAddress)
    {
        Id = id;
        Name = name;
        IpAddress = ipAddress;
    }

    public Guid Id { get; }
    public string Name { get; }
    public string IpAddress { get; }
}
