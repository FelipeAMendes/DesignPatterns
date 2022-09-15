namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// AbstractProductA
public abstract class Analyst
{
    protected Analyst(RequestLevel requestLevel)
    {
        RequestLevel = requestLevel;
    }

    public RequestLevel RequestLevel { get; }

    public abstract Ticket SolveTicket(Ticket ticket);
}

// ProductA1
public class AnalystN1 : Analyst
{
    public AnalystN1(RequestLevel requestLevel) : base(requestLevel) { }

    public override Ticket SolveTicket(Ticket ticket)
    {
        if (ticket.RequestLevel != RequestLevel.N1)
            throw new ArgumentException("N1 Requests Only");

        return ticket;
    }
}

// ProductA2
public class AnalystN2 : Analyst
{
    public AnalystN2(RequestLevel requestLevel) : base(requestLevel) { }

    public override Ticket SolveTicket(Ticket ticket)
    {
        if (ticket.RequestLevel == RequestLevel.N3)
            throw new ArgumentException("Only N1 or N2 requests");

        return ticket;
    }
}

// ProductA3
public class AnalystN3 : Analyst
{
    public AnalystN3(RequestLevel requestLevel) : base(requestLevel) { }

    public override Ticket SolveTicket(Ticket ticket) => ticket;
}

public class AnalystCreator
{
    public static Analyst Create(RequestLevel requestLevel)
    {
        return requestLevel switch
        {
            RequestLevel.N1 => new AnalystN1(requestLevel),
            RequestLevel.N2 => new AnalystN2(requestLevel),
            RequestLevel.N3 => new AnalystN3(requestLevel),
            _ => throw new ApplicationException("Option doesn't exist in enum.")
        };
    }
}