namespace DesignPatterns.BehavorialPatterns.Observer;

// Concrete Observer
public class Observer : IObserver
{
    public Observer(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public string Notify(Message newsletter)
    {
        return newsletter.Info;
    }
}
