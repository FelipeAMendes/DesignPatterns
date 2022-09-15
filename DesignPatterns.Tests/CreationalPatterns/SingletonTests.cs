using DesignPatterns.CreationalPatterns.Singleton;

namespace DesignPatterns.Tests.CreationalPatterns;

public class SingletonTests
{
    [Fact]
    public void LoadBalancerInstance_GetLoadBalancerMethodIsCalled_AllInstancesAreTheSame()
    {
        var balancer1 = LoadBalancer.GetLoadBalancer();
        var balancer2 = LoadBalancer.GetLoadBalancer();
        var balancer3 = LoadBalancer.GetLoadBalancer();
        var balancer4 = LoadBalancer.GetLoadBalancer();

        Assert.True(balancer1.Equals(balancer2));
        Assert.True(balancer2.Equals(balancer3));
        Assert.True(balancer3.Equals(balancer4));
        Assert.True(balancer4.Equals(balancer1));
    }

    [Fact]
    public void LoadBalancerInstance_GetNextServer_ReturnsDifferentServerNames()
    {
        var balancer = LoadBalancer.GetLoadBalancer();

        var balancerName1 = balancer.NextServer.Name;
        var balancerName2 = balancer.NextServer.Name;
        var balancerName3 = balancer.NextServer.Name;

        Assert.False(balancerName1.Equals(balancerName2));
        Assert.False(balancerName2.Equals(balancerName3));
    }
}
