namespace DesignPatterns.CreationalPatterns.AbstractFactory;

// AbstractProductB
public abstract class Ticket
{
    protected Ticket(RequestLevel requestLevel)
    {
        RequestLevel = requestLevel;
    }

    public RequestLevel RequestLevel { get; }
}

// ProductB1
public class TicketN1 : Ticket
{
    public TicketN1() : base(RequestLevel.N1) { }
}

// ProductB2
public class TicketN2 : Ticket
{
    public TicketN2() : base(RequestLevel.N2) { }
}

// ProductB3
public class TicketN3 : Ticket
{
    public TicketN3() : base(RequestLevel.N3) { }
}

public class TicketCreator
{
    public static Ticket Create(RequestLevel requestLevel)
    {
        return requestLevel switch
        {
            RequestLevel.N1 => new TicketN1(),
            RequestLevel.N2 => new TicketN2(),
            RequestLevel.N3 => new TicketN3(),
            _ => throw new ApplicationException("Option doesn't exist in enum.")
        };
    }
}
