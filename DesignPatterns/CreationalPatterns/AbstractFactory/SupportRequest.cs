namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// Client
public class SupportRequest
{
    private readonly Analyst _analyst;
    private readonly Ticket _ticket;

    public SupportRequest(SupportRequestFactory factory, RequestLevel ticketLevel)
    {
        _ticket = factory.CreateTicket(ticketLevel);
        _analyst = factory.CreateAnalyst();
    }

    public Ticket SolveTicket() => _analyst.SolveTicket(_ticket);

    public Analyst GetAnalyst() => _analyst;
}
