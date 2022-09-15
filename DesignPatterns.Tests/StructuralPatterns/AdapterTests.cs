using DesignPatterns.StructuralPatterns.Adapter;

namespace DesignPatterns.Tests.StructuralPatterns;

public class AdapterTests
{
    [Fact]
    public void PowerPlugDefault_ConnectMethodIsCalled_ReturnsConnectedStatus()
    {
        var powerPlugDefault = new ClientAdapter(new PowerPlug());

        var result = powerPlugDefault.Connect();

        Assert.Equal(expected: Status.Connected, result);
    }

    [Fact]
    public void PowerPlugAdapter_ConnectMethodAdapterIsCalled_ReturnsConnectedStatus()
    {
        var powerPlugAdapter = new ClientAdapter(new PowerPlugAdapter(new PowerPlugAdapterService()));

        var result = powerPlugAdapter.Connect();

        Assert.Equal(expected: Status.Connected, result);
        Assert.IsAssignableFrom<PowerPlugAdapter>(powerPlugAdapter.Adaptee);
    }

    [Fact]
    public void PowerPlugDefault_DisconnectMethodIsCalled_ReturnsDisconnectedStatus()
    {
        var powerPlugDefault = new ClientAdapter(new PowerPlug());

        var result = powerPlugDefault.Disconnect();

        Assert.Equal(expected: Status.Disconnected, result);
    }

    [Fact]
    public void PowerPlugAdapter_DisconnectMethodAdapterIsCalled_ReturnsDisconnectedStatus()
    {
        var powerPlugAdapter = new ClientAdapter(new PowerPlugAdapter(new PowerPlugAdapterService()));

        var result = powerPlugAdapter.Disconnect();

        Assert.Equal(expected: Status.Disconnected, result);
        Assert.IsAssignableFrom<PowerPlugAdapter>(powerPlugAdapter.Adaptee);
    }
}
