using DesignPatterns.CreationalPatterns.AbstractFactory;

namespace DesignPatterns.Tests.CreationalPatterns;

public class AbstractFactoryTests
{
    [Fact]
    public void TicketN1_SolveTicketIsCalled_ReturnsConcreteAnalystN1()
    {
        var supportRequest = new SupportRequest(new SupportRequestN1Factory(), ticketLevel: RequestLevel.N1);

        var ticketResult = supportRequest.SolveTicket();
        var analystN1 = supportRequest.GetAnalyst();

        Assert.Equal(RequestLevel.N1, ticketResult.RequestLevel);
        Assert.IsAssignableFrom<AnalystN1>(analystN1);
    }

    [Fact]
    public void TicketN2_SolveTicketIsCalled_ReturnsConcreteAnalystN2()
    {
        var supportRequest = new SupportRequest(new SupportRequestN2Factory(), ticketLevel: RequestLevel.N2);

        var ticketResult = supportRequest.SolveTicket();
        var analystN2 = supportRequest.GetAnalyst();

        Assert.Equal(RequestLevel.N2, ticketResult.RequestLevel);
        Assert.IsAssignableFrom<AnalystN2>(analystN2);
    }

    [Fact]
    public void TicketN1_SolveTicketIsCalled_ReturnsConcreteAnalystN3()
    {
        var supportRequest = new SupportRequest(new SupportRequestN3Factory(), RequestLevel.N1);

        var ticketResult = supportRequest.SolveTicket();
        var analystN3 = supportRequest.GetAnalyst();

        Assert.Equal(RequestLevel.N1, ticketResult.RequestLevel);
        Assert.IsAssignableFrom<AnalystN3>(analystN3);
    }

    [Fact]
    public void TicketN2_SolveTicketIsCalled_ReturnsConcreteAnalystN3()
    {
        var supportRequest = new SupportRequest(new SupportRequestN3Factory(), RequestLevel.N2);

        var ticketResult = supportRequest.SolveTicket();
        var analystN3 = supportRequest.GetAnalyst();

        Assert.Equal(RequestLevel.N2, ticketResult.RequestLevel);
        Assert.IsAssignableFrom<AnalystN3>(analystN3);
    }

    [Fact]
    public void TicketN3_SolveTicketIsCalled_ReturnsConcreteAnalystN3()
    {
        var supportRequest = new SupportRequest(new SupportRequestN3Factory(), RequestLevel.N3);

        var ticketResult = supportRequest.SolveTicket();
        var analystN3 = supportRequest.GetAnalyst();

        Assert.Equal(RequestLevel.N3, ticketResult.RequestLevel);
        Assert.IsAssignableFrom<AnalystN3>(analystN3);
    }

    [Fact]
    public void TicketN2_AnalystN1SolveTicketIsCalled_ThrowArgumentException()
    {
        var supportRequest = new SupportRequest(new SupportRequestN1Factory(), RequestLevel.N2);

        Ticket Operation() => supportRequest.SolveTicket();

        Assert.Throws<ArgumentException>(Operation);
    }

    [Fact]
    public void TicketN3_AnalystN1SolveTicketIsCalled_ThrowArgumentException()
    {
        var supportRequest = new SupportRequest(new SupportRequestN1Factory(), RequestLevel.N3);

        Ticket Operation() => supportRequest.SolveTicket();

        Assert.Throws<ArgumentException>(Operation);
    }

    [Fact]
    public void TicketN3_AnalystN2SolveTicketIsCalled_ThrowArgumentException()
    {
        var supportRequest = new SupportRequest(new SupportRequestN2Factory(), RequestLevel.N3);

        Ticket Operation() => supportRequest.SolveTicket();

        Assert.Throws<ArgumentException>(Operation);
    }
}