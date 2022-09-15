namespace DesignPatterns.BehavorialPatterns.Observer;

// Observer
public interface IObserver
{
    string Name { get; }
    string Notify(Message investment);
}
