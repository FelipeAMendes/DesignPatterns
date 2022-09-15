using DesignPatterns.BehavorialPatterns.Observer;

namespace DesignPatterns.Tests.BehavorialPatterns;

public class ObserverTests
{
    [Fact]
    public void InfoMessage_SubscribeMethodIsCalled_ReturnsSubscribersCorrectly()
    {
        var infoMessage = new InfoMessage("InfoMessage");

        infoMessage.Subscribe(new Observer("John"));
        infoMessage.Subscribe(new Observer("Rick"));

        infoMessage.ChangeInfo("InfoMessage Changed");

        Assert.Equal(expected: 2, infoMessage.Observers.Count);
        Assert.Equal(expected: 2, infoMessage.ChangedMessages.Count);
    }

    [Fact]
    public void InfoMessage_UnSubscribeMethodIsCalled_ReturnsSubscribersCorrectly()
    {
        var infoMessage = new InfoMessage("InfoMessage");

        infoMessage.Subscribe(new Observer("John"));
        var rick = infoMessage.Subscribe(new Observer("Rick"));

        infoMessage.ChangeInfo("InfoMessage Changed");

        Assert.Equal(expected: 2, infoMessage.Observers.Count);
        Assert.Equal(expected: 2, infoMessage.ChangedMessages.Count);

        infoMessage.UnSubscribe(rick);

        Assert.Single(infoMessage.Observers);
    }

    [Fact]
    public void MoreThanOneInfoMessage_UnSubscribeMethodIsCalled_ReturnsSubscribersCorrectly()
    {
        var john = new Observer("John");
        var rick = new Observer("Rick");

        var infoMessage1 = new InfoMessage("InfoMessage 1");
        var infoMessage2 = new InfoMessage("InfoMessage 2");

        infoMessage1.Subscribe(john);
        infoMessage1.Subscribe(rick);
        infoMessage2.Subscribe(rick);

        infoMessage1.ChangeInfo("InfoMessage 1 Changed");
        infoMessage2.ChangeInfo("InfoMessage 2 Changed");

        Assert.Equal(expected: 2, infoMessage1.Observers.Count);
        Assert.Equal(expected: 2, infoMessage1.ChangedMessages.Count);

        Assert.Single(infoMessage2.Observers);
        Assert.Single(infoMessage2.ChangedMessages);

        infoMessage1.UnSubscribe(rick);

        Assert.Single(infoMessage1.Observers);
    }
}
