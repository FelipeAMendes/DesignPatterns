namespace DesignPatterns.CreationalPatterns.Singleton;

public sealed class LoadBalancer
{
    private static readonly LoadBalancer Instance = new();
    private readonly Random _random = new();

    private readonly List<Server> _servers;

    private LoadBalancer()
    {
        _servers = new List<Server>
        {
            new(Guid.NewGuid(), "Server I", "162.60.150.1"),
            new(Guid.NewGuid(), "Server II", "192.60.150.2"),
            new(Guid.NewGuid(), "Server III", "192.60.150.3"),
            new(Guid.NewGuid(), "Server IV", "192.60.150.4"),
            new(Guid.NewGuid(), "Server V", "192.60.150.5")
        };
    }

    public Server NextServer
    {
        get
        {
            var r = _random.Next(_servers.Count);
            return _servers[r];
        }
    }

    public static LoadBalancer GetLoadBalancer()
    {
        return Instance;
    }
}
