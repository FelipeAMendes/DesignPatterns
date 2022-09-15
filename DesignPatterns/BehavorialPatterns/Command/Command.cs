namespace DesignPatterns.BehavorialPatterns.Command;

// Command abstract class
public abstract class Command
{
    public int Current { get; protected set; }
    public abstract void Execute();
    public abstract void UnExecute();
}
