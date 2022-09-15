namespace DesignPatterns.BehavorialPatterns.Observer;

// Concrete Subject
public class InfoMessage : Message
{
    public InfoMessage(string description)
        : base(description)
    { }
}
