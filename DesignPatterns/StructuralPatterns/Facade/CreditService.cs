namespace DesignPatterns.StructuralPatterns.Facade;

public interface ICreditService
{
    bool HasGoodCredit(Customer customer);
}

// Subsystem ClassB
public class CreditService : ICreditService
{
    public CreditService(bool goodCredit)
    {
        GoodCredit = goodCredit;
    }

    public bool GoodCredit { get; }

    public bool HasGoodCredit(Customer customer)
    {
        Console.WriteLine("Check credit for " + customer.Name);
        return GoodCredit;
    }
}
