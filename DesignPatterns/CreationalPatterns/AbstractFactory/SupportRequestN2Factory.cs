namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// ConcreteFactory2
public class SupportRequestN2Factory : SupportRequestFactory
{
    public override Ticket CreateTicket(RequestLevel level)
    {
        return TicketCreator.Create(level);
    }

    public override Analyst CreateAnalyst()
    {
        return AnalystCreator.Create(RequestLevel.N2);
    }
}