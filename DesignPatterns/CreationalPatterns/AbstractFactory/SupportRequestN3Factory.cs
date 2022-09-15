namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// ConcreteFactory3
public class SupportRequestN3Factory : SupportRequestFactory
{
    public override Ticket CreateTicket(RequestLevel level)
    {
        return TicketCreator.Create(level);
    }

    public override Analyst CreateAnalyst()
    {
        return AnalystCreator.Create(RequestLevel.N3);
    }
}