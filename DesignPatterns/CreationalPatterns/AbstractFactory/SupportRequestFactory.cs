namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// AbstractFactory
public abstract class SupportRequestFactory
{
    public abstract Ticket CreateTicket(RequestLevel level);

    public abstract Analyst CreateAnalyst();
}
