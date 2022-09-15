namespace DesignPatterns.StructuralPatterns.Facade;

public interface IBankService
{
    bool HasSufficientSavings(Customer customer, int amount);
}

// SubSystem ClassA
public class BankService : IBankService
{
    public BankService(bool sufficientSavings)
    {
        SufficientSavings = sufficientSavings;
    }

    public bool SufficientSavings { get; }

    public bool HasSufficientSavings(Customer customer, int amount)
    {
        Console.WriteLine($"Check bank for {customer.Name} {amount}");
        return SufficientSavings;
    }
}
