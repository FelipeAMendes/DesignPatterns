namespace DesignPatterns.StructuralPatterns.Facade;

public interface ILoanService
{
    bool HasNoBadLoans(Customer customer);
}

// Subsystem ClassC
public class LoanService : ILoanService
{
    public LoanService(bool badLoans)
    {
        BadLoans = badLoans;
    }

    public bool BadLoans { get; }

    public bool HasNoBadLoans(Customer customer)
    {
        Console.WriteLine("Check loans for " + customer.Name);
        return BadLoans;
    }
}