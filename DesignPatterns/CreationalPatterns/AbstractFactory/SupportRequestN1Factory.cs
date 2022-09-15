namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// ConcreteFactory1
public class SupportRequestN1Factory : SupportRequestFactory
{
    public override Ticket CreateTicket(RequestLevel level)
    {
        return TicketCreator.Create(level);
    }

    public override Analyst CreateAnalyst()
    {
        return AnalystCreator.Create(RequestLevel.N1);
    }
}