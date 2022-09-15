namespace DesignPatterns.BehavorialPatterns.Observer;

// Subject
public abstract class Message
{
    public readonly List<IObserver> Observers = new();
    public readonly List<string> ChangedMessages = new();// To test

    protected Message(string info)
    {
        Info = info;
    }

    public string Info { get; private set; }

    public void ChangeInfo(string info)
    {
        if (info == Info) return;

        Info = info;
        Notify();
    }

    public IObserver Subscribe(IObserver observer)
    {
        Observers.Add(observer);
        return observer;
    }

    public void UnSubscribe(IObserver observer)
    {
        Observers.Remove(observer);
    }

    private void Notify()
    {
        foreach (var observer in Observers)
        {
            observer.Notify(this);
            ChangedMessages.Add(Info);
        }
    }
}
